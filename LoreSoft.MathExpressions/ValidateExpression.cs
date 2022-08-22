using LoreSoft.MathExpressions.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace LoreSoft.MathExpressions
{
    public class ValidateExpression
    {
        private Stack<string> _symbolStack;
        private Queue<IExpression> _expressionQueue;
        private Dictionary<string, IExpression> _expressionCache;
        private StringBuilder _buffer;
        private Stack<double> _calculationStack;
        private Stack<double> _parameters;
        private List<string> _innerFunctions;
        private uint _nestedFunctionDepth;
        private uint _nestedGroupDepth;
        private StringReader _expressionReader;
        private VariableDictionary _variables;
        private ReadOnlyCollection<string> _functions;
        private char _currentChar;

        public ValidateExpression()
        {
            _innerFunctions = new List<string>(FunctionExpression.GetFunctionNames());
            _innerFunctions.Sort();
            _functions = new ReadOnlyCollection<string>(_innerFunctions);
            _expressionCache = new Dictionary<string, IExpression>(StringComparer.OrdinalIgnoreCase);
            _symbolStack = new Stack<string>();
            _expressionQueue = new Queue<IExpression>();
            _buffer = new StringBuilder();
            _calculationStack = new Stack<double>();
            _parameters = new Stack<double>(2);
            _nestedFunctionDepth = 0;
            _nestedGroupDepth = 0;
        }
        public void startStuff(string expression)
        {
            _expressionReader = new StringReader(expression);
            _symbolStack.Clear();
            _nestedFunctionDepth = 0;
            _nestedGroupDepth = 0;
            _expressionQueue.Clear();

           
            _currentChar = '\0';
        }
        public bool Validate(string expression)

        {
            if (string.IsNullOrEmpty(expression))//1
                return false;//2
            char lastChar = '\0';//3
            startStuff(expression);//4
            do//
            {
                // last non white space char
                if (!char.IsWhiteSpace(_currentChar))//5
                    lastChar = _currentChar;//6

                _currentChar = (char)_expressionReader.Read();//

                if (char.IsWhiteSpace(_currentChar))//7
                    continue;

                if (TryNumber(lastChar))//9
                    continue;

                if (TryString())//10
                    continue;

                if (TryStartGroup())//11
                    continue;

                if (TryComma())//12
                    continue;

                if (TryOperator())//13
                    continue;

                if (TryEndGroup())//14
                    continue;



                return false;//15
            } while (_expressionReader.Peek() != -1);//16

            ProcessSymbolStack();//17
            return true;//18
        }
    

       
        private bool TryString()
        {
            if (!char.IsLetter(_currentChar))
                return false;

            _buffer.Length = 0;
            _buffer.Append(_currentChar);

            char p = (char)_expressionReader.Peek();
            while (char.IsLetter(p) || char.IsNumber(p))
            {
                _buffer.Append((char)_expressionReader.Read());
                p = (char)_expressionReader.Peek();
            }

            if (_variables.ContainsKey(_buffer.ToString()))
            {
                double value = _variables[_buffer.ToString()];
                NumberExpression expression = new NumberExpression(value);
                _expressionQueue.Enqueue(expression);

                return true;
            }

            if (IsFunction(_buffer.ToString()))
            {
                _symbolStack.Push(_buffer.ToString());
                _nestedFunctionDepth++;
                return true;
            }

            return false;
        }

        private bool TryStartGroup()
        {
            if (_currentChar != '(')
                return false;

            if (PeekNextNonWhitespaceChar() == ',')
            {
                throw new ParseException(Resources.InvalidCharacterEncountered + ",");
            }

            _symbolStack.Push(_currentChar.ToString());
            _nestedGroupDepth++;
            return true;
        }

        private bool TryComma()
        {
            if (_currentChar != ',')
                return false;

            if (_nestedFunctionDepth <= 0 ||
                _nestedFunctionDepth < _nestedGroupDepth)
            {
                throw new ParseException(Resources.InvalidCharacterEncountered + _currentChar);
            }

            char nextChar = PeekNextNonWhitespaceChar();
            if (nextChar == ')' || nextChar == ',')
            {
                throw new ParseException(Resources.InvalidCharacterEncountered + _currentChar);
            }

            return true;
        }

        private char PeekNextNonWhitespaceChar()
        {
            int next = _expressionReader.Peek();
            while (next != -1 && char.IsWhiteSpace((char)next))
            {
                _expressionReader.Read();
                next = _expressionReader.Peek();
            }
            return (char)next;
        }


        private bool TryEndGroup()
        {
            if (_currentChar != ')')
                return false;

            bool hasStart = false;

            while (_symbolStack.Count > 0)
            {
                string p = _symbolStack.Pop();
                if (p == "(")
                {
                    hasStart = true;

                    if (_symbolStack.Count == 0)
                        break;

                    string n = _symbolStack.Peek();
                    if (IsFunction(n))
                    {
                        p = _symbolStack.Pop();
                        IExpression f = GetExpressionFromSymbol(p);
                        _expressionQueue.Enqueue(f);
                        _nestedFunctionDepth--;
                    }

                    _nestedGroupDepth--;

                    break;
                }

                IExpression e = GetExpressionFromSymbol(p);
                _expressionQueue.Enqueue(e);
            }

            if (!hasStart)
                throw new ParseException(Resources.UnbalancedParentheses);

            return true;
        }
        private bool TryOperator()
        {
            if (!OperatorExpression.IsSymbol(_currentChar))
                return false;

            bool repeat;
            string s = _currentChar.ToString();

            do
            {
                string p = _symbolStack.Count == 0 ? string.Empty : _symbolStack.Peek();
                repeat = false;
                if (_symbolStack.Count == 0)
                    _symbolStack.Push(s);
                else if (p == "(")
                    _symbolStack.Push(s);
                else if (Precedence(s) > Precedence(p))
                    _symbolStack.Push(s);
                else
                {
                    IExpression e = GetExpressionFromSymbol(_symbolStack.Pop());
                    _expressionQueue.Enqueue(e);
                    repeat = true;
                }
            } while (repeat);

            return true;
        }

        private bool TryNumber(char lastChar)
        {
            bool isNumber = NumberExpression.IsNumber(_currentChar);
            // only negative when last char is group start or symbol
            bool isNegative = NumberExpression.IsNegativeSign(_currentChar) &&
                              (lastChar == '\0' || lastChar == '(' || OperatorExpression.IsSymbol(lastChar));

            if (!isNumber && !isNegative)
                return false;

            _buffer.Length = 0;
            _buffer.Append(_currentChar);

            char p = (char)_expressionReader.Peek();
            while (NumberExpression.IsNumber(p))
            {
                _currentChar = (char)_expressionReader.Read();
                _buffer.Append(_currentChar);
                p = (char)_expressionReader.Peek();
            }

            double value;
            if (!(double.TryParse(_buffer.ToString(), out value)))
                return false; ;

            NumberExpression expression = new NumberExpression(value);
            _expressionQueue.Enqueue(expression);

            return true;
        }
        private bool ProcessSymbolStack()
        {
            while (_symbolStack.Count > 0)
            {
                string p = _symbolStack.Pop();
                if (p.Length == 1 && p == "(")
                    return false;

                IExpression e = GetExpressionFromSymbol(p);
                _expressionQueue.Enqueue(e);
            }
            return true;
        }
        private IExpression GetExpressionFromSymbol(string p)
        {
            IExpression e;

            if (_expressionCache.ContainsKey(p))
                e = _expressionCache[p];
            else if (OperatorExpression.IsSymbol(p))
            {
                e = new OperatorExpression(p);
                _expressionCache.Add(p, e);
            }
            else if (FunctionExpression.IsFunction(p))
            {
                e = new FunctionExpression(p, false);
                _expressionCache.Add(p, e);
            }

            else
                throw new ParseException(Resources.InvalidSymbolOnStack + p);

            return e;
        }
        internal bool IsFunction(string name)
        {
            return (_innerFunctions.BinarySearch(name, StringComparer.OrdinalIgnoreCase) >= 0);
        }
        private static int Precedence(string c)
        {
            if (c.Length == 1 && (c[0] == '*' || c[0] == '/' || c[0] == '%'))
                return 2;

            return 1;
        }

    }

}