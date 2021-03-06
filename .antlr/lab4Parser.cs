//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Javalib\lab4.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class lab4Parser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		WS=1, Typenumber=2, Typereal=3, Typechar=4, Typebool=5, Constnumber=6, 
		Constreal=7, Constchar=8, Constbool=9, Constseven=10, Exp=11, ArifmOp=12, 
		ArifmOpExt=13, LogOp=14, LbParam=15, RbParam=16, LfBracket=17, RfBracket=18, 
		LineSep=19, Prisv=20, IdentSep=21, While=22, Do=23, End=24, Ident=25;
	public const int
		RULE_main = 0, RULE_statement = 1, RULE_whiledo = 2, RULE_whilecondition = 3, 
		RULE_dobody = 4, RULE_declaration = 5, RULE_assign = 6, RULE_arifmoperation = 7, 
		RULE_typedata = 8, RULE_const = 9, RULE_operands = 10;
	public static readonly string[] ruleNames = {
		"main", "statement", "whiledo", "whilecondition", "dobody", "declaration", 
		"assign", "arifmoperation", "typedata", "const", "operands"
	};

	private static readonly string[] _LiteralNames = {
		null, null, "'number'", "'real'", null, "'bool'", null, null, null, null, 
		null, null, null, null, null, "'('", "')'", "'{'", "'}'", "';'", "':='", 
		"','", "'while'", "'do'", "'end'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WS", "Typenumber", "Typereal", "Typechar", "Typebool", "Constnumber", 
		"Constreal", "Constchar", "Constbool", "Constseven", "Exp", "ArifmOp", 
		"ArifmOpExt", "LogOp", "LbParam", "RbParam", "LfBracket", "RfBracket", 
		"LineSep", "Prisv", "IdentSep", "While", "Do", "End", "Ident"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "lab4.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static lab4Parser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public lab4Parser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public lab4Parser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class MainContext : ParserRuleContext {
		public DeclarationContext[] declaration() {
			return GetRuleContexts<DeclarationContext>();
		}
		public DeclarationContext declaration(int i) {
			return GetRuleContext<DeclarationContext>(i);
		}
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public MainContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_main; } }
	}

	[RuleVersion(0)]
	public MainContext main() {
		MainContext _localctx = new MainContext(Context, State);
		EnterRule(_localctx, 0, RULE_main);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 25;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Typenumber) | (1L << Typereal) | (1L << Typechar) | (1L << Typebool))) != 0)) {
				{
				{
				State = 22; declaration();
				}
				}
				State = 27;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 31;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==While || _la==Ident) {
				{
				{
				State = 28; statement();
				}
				}
				State = 33;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		public AssignContext assign() {
			return GetRuleContext<AssignContext>(0);
		}
		public WhiledoContext whiledo() {
			return GetRuleContext<WhiledoContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 2, RULE_statement);
		try {
			State = 36;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case Ident:
				EnterOuterAlt(_localctx, 1);
				{
				State = 34; assign();
				}
				break;
			case While:
				EnterOuterAlt(_localctx, 2);
				{
				State = 35; whiledo();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WhiledoContext : ParserRuleContext {
		public ITerminalNode While() { return GetToken(lab4Parser.While, 0); }
		public WhileconditionContext whilecondition() {
			return GetRuleContext<WhileconditionContext>(0);
		}
		public ITerminalNode Do() { return GetToken(lab4Parser.Do, 0); }
		public DobodyContext dobody() {
			return GetRuleContext<DobodyContext>(0);
		}
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public WhiledoContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whiledo; } }
	}

	[RuleVersion(0)]
	public WhiledoContext whiledo() {
		WhiledoContext _localctx = new WhiledoContext(Context, State);
		EnterRule(_localctx, 4, RULE_whiledo);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 38; Match(While);
			State = 39; whilecondition();
			State = 40; Match(Do);
			State = 41; dobody();
			State = 45;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 42; statement();
					}
					} 
				}
				State = 47;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class WhileconditionContext : ParserRuleContext {
		public ITerminalNode LbParam() { return GetToken(lab4Parser.LbParam, 0); }
		public ITerminalNode RbParam() { return GetToken(lab4Parser.RbParam, 0); }
		public ITerminalNode[] Constbool() { return GetTokens(lab4Parser.Constbool); }
		public ITerminalNode Constbool(int i) {
			return GetToken(lab4Parser.Constbool, i);
		}
		public OperandsContext[] operands() {
			return GetRuleContexts<OperandsContext>();
		}
		public OperandsContext operands(int i) {
			return GetRuleContext<OperandsContext>(i);
		}
		public ITerminalNode LogOp() { return GetToken(lab4Parser.LogOp, 0); }
		public WhileconditionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_whilecondition; } }
	}

	[RuleVersion(0)]
	public WhileconditionContext whilecondition() {
		WhileconditionContext _localctx = new WhileconditionContext(Context, State);
		EnterRule(_localctx, 6, RULE_whilecondition);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 48; Match(LbParam);
			State = 51;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				{
				State = 49; Match(Constbool);
				}
				break;
			case 2:
				{
				State = 50; operands();
				}
				break;
			}
			State = 58;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==LogOp) {
				{
				State = 53; Match(LogOp);
				State = 56;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
				case 1:
					{
					State = 54; Match(Constbool);
					}
					break;
				case 2:
					{
					State = 55; operands();
					}
					break;
				}
				}
			}

			State = 60; Match(RbParam);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DobodyContext : ParserRuleContext {
		public ITerminalNode LfBracket() { return GetToken(lab4Parser.LfBracket, 0); }
		public ITerminalNode RfBracket() { return GetToken(lab4Parser.RfBracket, 0); }
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public DobodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dobody; } }
	}

	[RuleVersion(0)]
	public DobodyContext dobody() {
		DobodyContext _localctx = new DobodyContext(Context, State);
		EnterRule(_localctx, 8, RULE_dobody);
		int _la;
		try {
			State = 71;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LfBracket:
				EnterOuterAlt(_localctx, 1);
				{
				State = 62; Match(LfBracket);
				State = 66;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==While || _la==Ident) {
					{
					{
					State = 63; statement();
					}
					}
					State = 68;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 69; Match(RfBracket);
				}
				break;
			case While:
			case Ident:
				EnterOuterAlt(_localctx, 2);
				{
				State = 70; statement();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationContext : ParserRuleContext {
		public TypedataContext typedata() {
			return GetRuleContext<TypedataContext>(0);
		}
		public ITerminalNode[] Ident() { return GetTokens(lab4Parser.Ident); }
		public ITerminalNode Ident(int i) {
			return GetToken(lab4Parser.Ident, i);
		}
		public ITerminalNode LineSep() { return GetToken(lab4Parser.LineSep, 0); }
		public ITerminalNode[] IdentSep() { return GetTokens(lab4Parser.IdentSep); }
		public ITerminalNode IdentSep(int i) {
			return GetToken(lab4Parser.IdentSep, i);
		}
		public ITerminalNode Typenumber() { return GetToken(lab4Parser.Typenumber, 0); }
		public ITerminalNode Prisv() { return GetToken(lab4Parser.Prisv, 0); }
		public ITerminalNode Constnumber() { return GetToken(lab4Parser.Constnumber, 0); }
		public ITerminalNode Typereal() { return GetToken(lab4Parser.Typereal, 0); }
		public ITerminalNode Constreal() { return GetToken(lab4Parser.Constreal, 0); }
		public ITerminalNode Typechar() { return GetToken(lab4Parser.Typechar, 0); }
		public ITerminalNode Constchar() { return GetToken(lab4Parser.Constchar, 0); }
		public ITerminalNode Typebool() { return GetToken(lab4Parser.Typebool, 0); }
		public ITerminalNode Constbool() { return GetToken(lab4Parser.Constbool, 0); }
		public DeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaration; } }
	}

	[RuleVersion(0)]
	public DeclarationContext declaration() {
		DeclarationContext _localctx = new DeclarationContext(Context, State);
		EnterRule(_localctx, 10, RULE_declaration);
		int _la;
		try {
			State = 104;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,10,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 73; typedata();
				State = 74; Match(Ident);
				State = 79;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while (_la==IdentSep) {
					{
					{
					State = 75; Match(IdentSep);
					State = 76; Match(Ident);
					}
					}
					State = 81;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 82; Match(LineSep);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 84; Match(Typenumber);
				State = 85; Match(Ident);
				State = 86; Match(Prisv);
				State = 87; Match(Constnumber);
				State = 88; Match(LineSep);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 89; Match(Typereal);
				State = 90; Match(Ident);
				State = 91; Match(Prisv);
				State = 92; Match(Constreal);
				State = 93; Match(LineSep);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 94; Match(Typechar);
				State = 95; Match(Ident);
				State = 96; Match(Prisv);
				State = 97; Match(Constchar);
				State = 98; Match(LineSep);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 99; Match(Typebool);
				State = 100; Match(Ident);
				State = 101; Match(Prisv);
				State = 102; Match(Constbool);
				State = 103; Match(LineSep);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AssignContext : ParserRuleContext {
		public ITerminalNode Ident() { return GetToken(lab4Parser.Ident, 0); }
		public ITerminalNode Prisv() { return GetToken(lab4Parser.Prisv, 0); }
		public OperandsContext operands() {
			return GetRuleContext<OperandsContext>(0);
		}
		public ITerminalNode LineSep() { return GetToken(lab4Parser.LineSep, 0); }
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public AssignContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assign; } }
	}

	[RuleVersion(0)]
	public AssignContext assign() {
		AssignContext _localctx = new AssignContext(Context, State);
		EnterRule(_localctx, 12, RULE_assign);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 106; Match(Ident);
			State = 107; Match(Prisv);
			State = 108; operands();
			State = 109; Match(LineSep);
			State = 113;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,11,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 110; statement();
					}
					} 
				}
				State = 115;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,11,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ArifmoperationContext : ParserRuleContext {
		public ITerminalNode ArifmOp() { return GetToken(lab4Parser.ArifmOp, 0); }
		public OperandsContext operands() {
			return GetRuleContext<OperandsContext>(0);
		}
		public ITerminalNode Ident() { return GetToken(lab4Parser.Ident, 0); }
		public ConstContext @const() {
			return GetRuleContext<ConstContext>(0);
		}
		public ITerminalNode ArifmOpExt() { return GetToken(lab4Parser.ArifmOpExt, 0); }
		public ITerminalNode LbParam() { return GetToken(lab4Parser.LbParam, 0); }
		public ArifmoperationContext arifmoperation() {
			return GetRuleContext<ArifmoperationContext>(0);
		}
		public ITerminalNode RbParam() { return GetToken(lab4Parser.RbParam, 0); }
		public ArifmoperationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_arifmoperation; } }
	}

	[RuleVersion(0)]
	public ArifmoperationContext arifmoperation() {
		ArifmoperationContext _localctx = new ArifmoperationContext(Context, State);
		EnterRule(_localctx, 14, RULE_arifmoperation);
		try {
			State = 128;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,13,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 118;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case Ident:
					{
					State = 116; Match(Ident);
					}
					break;
				case Constnumber:
				case Constreal:
				case Constchar:
				case Constbool:
				case Constseven:
					{
					State = 117; @const();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 120; Match(ArifmOp);
				State = 121; operands();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 122; Match(Ident);
				State = 123; Match(ArifmOpExt);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 124; Match(LbParam);
				State = 125; arifmoperation();
				State = 126; Match(RbParam);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypedataContext : ParserRuleContext {
		public ITerminalNode Typenumber() { return GetToken(lab4Parser.Typenumber, 0); }
		public ITerminalNode Typereal() { return GetToken(lab4Parser.Typereal, 0); }
		public ITerminalNode Typechar() { return GetToken(lab4Parser.Typechar, 0); }
		public ITerminalNode Typebool() { return GetToken(lab4Parser.Typebool, 0); }
		public TypedataContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_typedata; } }
	}

	[RuleVersion(0)]
	public TypedataContext typedata() {
		TypedataContext _localctx = new TypedataContext(Context, State);
		EnterRule(_localctx, 16, RULE_typedata);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 130;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Typenumber) | (1L << Typereal) | (1L << Typechar) | (1L << Typebool))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConstContext : ParserRuleContext {
		public ITerminalNode Constnumber() { return GetToken(lab4Parser.Constnumber, 0); }
		public ITerminalNode Constreal() { return GetToken(lab4Parser.Constreal, 0); }
		public ITerminalNode Constchar() { return GetToken(lab4Parser.Constchar, 0); }
		public ITerminalNode Constbool() { return GetToken(lab4Parser.Constbool, 0); }
		public ITerminalNode Constseven() { return GetToken(lab4Parser.Constseven, 0); }
		public ConstContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_const; } }
	}

	[RuleVersion(0)]
	public ConstContext @const() {
		ConstContext _localctx = new ConstContext(Context, State);
		EnterRule(_localctx, 18, RULE_const);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 132;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << Constnumber) | (1L << Constreal) | (1L << Constchar) | (1L << Constbool) | (1L << Constseven))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OperandsContext : ParserRuleContext {
		public ITerminalNode Ident() { return GetToken(lab4Parser.Ident, 0); }
		public ConstContext @const() {
			return GetRuleContext<ConstContext>(0);
		}
		public ArifmoperationContext arifmoperation() {
			return GetRuleContext<ArifmoperationContext>(0);
		}
		public OperandsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_operands; } }
	}

	[RuleVersion(0)]
	public OperandsContext operands() {
		OperandsContext _localctx = new OperandsContext(Context, State);
		EnterRule(_localctx, 20, RULE_operands);
		try {
			State = 137;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,14,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 134; Match(Ident);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 135; @const();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 136; arifmoperation();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x1B', '\x8E', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', 
		'\x4', '\f', '\t', '\f', '\x3', '\x2', '\a', '\x2', '\x1A', '\n', '\x2', 
		'\f', '\x2', '\xE', '\x2', '\x1D', '\v', '\x2', '\x3', '\x2', '\a', '\x2', 
		' ', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '#', '\v', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x5', '\x3', '\'', '\n', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '.', '\n', 
		'\x4', '\f', '\x4', '\xE', '\x4', '\x31', '\v', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x5', '\x5', '\x36', '\n', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x5', '\x5', ';', '\n', '\x5', '\x5', '\x5', 
		'=', '\n', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', 
		'\a', '\x6', '\x43', '\n', '\x6', '\f', '\x6', '\xE', '\x6', '\x46', '\v', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', 'J', '\n', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\a', '\a', 'P', '\n', '\a', 
		'\f', '\a', '\xE', '\a', 'S', '\v', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x5', '\a', 'k', '\n', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b', 
		'r', '\n', '\b', '\f', '\b', '\xE', '\b', 'u', '\v', '\b', '\x3', '\t', 
		'\x3', '\t', '\x5', '\t', 'y', '\n', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x5', '\t', '\x83', '\n', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x5', '\f', '\x8C', 
		'\n', '\f', '\x3', '\f', '\x2', '\x2', '\r', '\x2', '\x4', '\x6', '\b', 
		'\n', '\f', '\xE', '\x10', '\x12', '\x14', '\x16', '\x2', '\x4', '\x3', 
		'\x2', '\x4', '\a', '\x3', '\x2', '\b', '\f', '\x2', '\x96', '\x2', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '\x4', '&', '\x3', '\x2', '\x2', '\x2', '\x6', 
		'(', '\x3', '\x2', '\x2', '\x2', '\b', '\x32', '\x3', '\x2', '\x2', '\x2', 
		'\n', 'I', '\x3', '\x2', '\x2', '\x2', '\f', 'j', '\x3', '\x2', '\x2', 
		'\x2', '\xE', 'l', '\x3', '\x2', '\x2', '\x2', '\x10', '\x82', '\x3', 
		'\x2', '\x2', '\x2', '\x12', '\x84', '\x3', '\x2', '\x2', '\x2', '\x14', 
		'\x86', '\x3', '\x2', '\x2', '\x2', '\x16', '\x8B', '\x3', '\x2', '\x2', 
		'\x2', '\x18', '\x1A', '\x5', '\f', '\a', '\x2', '\x19', '\x18', '\x3', 
		'\x2', '\x2', '\x2', '\x1A', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\x1C', '!', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x1E', ' ', '\x5', '\x4', '\x3', '\x2', '\x1F', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', ' ', '#', '\x3', '\x2', '\x2', '\x2', 
		'!', '\x1F', '\x3', '\x2', '\x2', '\x2', '!', '\"', '\x3', '\x2', '\x2', 
		'\x2', '\"', '\x3', '\x3', '\x2', '\x2', '\x2', '#', '!', '\x3', '\x2', 
		'\x2', '\x2', '$', '\'', '\x5', '\xE', '\b', '\x2', '%', '\'', '\x5', 
		'\x6', '\x4', '\x2', '&', '$', '\x3', '\x2', '\x2', '\x2', '&', '%', '\x3', 
		'\x2', '\x2', '\x2', '\'', '\x5', '\x3', '\x2', '\x2', '\x2', '(', ')', 
		'\a', '\x18', '\x2', '\x2', ')', '*', '\x5', '\b', '\x5', '\x2', '*', 
		'+', '\a', '\x19', '\x2', '\x2', '+', '/', '\x5', '\n', '\x6', '\x2', 
		',', '.', '\x5', '\x4', '\x3', '\x2', '-', ',', '\x3', '\x2', '\x2', '\x2', 
		'.', '\x31', '\x3', '\x2', '\x2', '\x2', '/', '-', '\x3', '\x2', '\x2', 
		'\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '/', '\x3', '\x2', '\x2', '\x2', '\x32', '\x35', 
		'\a', '\x11', '\x2', '\x2', '\x33', '\x36', '\a', '\v', '\x2', '\x2', 
		'\x34', '\x36', '\x5', '\x16', '\f', '\x2', '\x35', '\x33', '\x3', '\x2', 
		'\x2', '\x2', '\x35', '\x34', '\x3', '\x2', '\x2', '\x2', '\x36', '<', 
		'\x3', '\x2', '\x2', '\x2', '\x37', ':', '\a', '\x10', '\x2', '\x2', '\x38', 
		';', '\a', '\v', '\x2', '\x2', '\x39', ';', '\x5', '\x16', '\f', '\x2', 
		':', '\x38', '\x3', '\x2', '\x2', '\x2', ':', '\x39', '\x3', '\x2', '\x2', 
		'\x2', ';', '=', '\x3', '\x2', '\x2', '\x2', '<', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '<', '=', '\x3', '\x2', '\x2', '\x2', '=', '>', '\x3', '\x2', 
		'\x2', '\x2', '>', '?', '\a', '\x12', '\x2', '\x2', '?', '\t', '\x3', 
		'\x2', '\x2', '\x2', '@', '\x44', '\a', '\x13', '\x2', '\x2', '\x41', 
		'\x43', '\x5', '\x4', '\x3', '\x2', '\x42', '\x41', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\x46', '\x3', '\x2', '\x2', '\x2', '\x44', '\x42', '\x3', 
		'\x2', '\x2', '\x2', '\x44', '\x45', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'G', '\x3', '\x2', '\x2', '\x2', '\x46', '\x44', '\x3', '\x2', '\x2', 
		'\x2', 'G', 'J', '\a', '\x14', '\x2', '\x2', 'H', 'J', '\x5', '\x4', '\x3', 
		'\x2', 'I', '@', '\x3', '\x2', '\x2', '\x2', 'I', 'H', '\x3', '\x2', '\x2', 
		'\x2', 'J', '\v', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\x5', '\x12', 
		'\n', '\x2', 'L', 'Q', '\a', '\x1B', '\x2', '\x2', 'M', 'N', '\a', '\x17', 
		'\x2', '\x2', 'N', 'P', '\a', '\x1B', '\x2', '\x2', 'O', 'M', '\x3', '\x2', 
		'\x2', '\x2', 'P', 'S', '\x3', '\x2', '\x2', '\x2', 'Q', 'O', '\x3', '\x2', 
		'\x2', '\x2', 'Q', 'R', '\x3', '\x2', '\x2', '\x2', 'R', 'T', '\x3', '\x2', 
		'\x2', '\x2', 'S', 'Q', '\x3', '\x2', '\x2', '\x2', 'T', 'U', '\a', '\x15', 
		'\x2', '\x2', 'U', 'k', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\a', '\x4', 
		'\x2', '\x2', 'W', 'X', '\a', '\x1B', '\x2', '\x2', 'X', 'Y', '\a', '\x16', 
		'\x2', '\x2', 'Y', 'Z', '\a', '\b', '\x2', '\x2', 'Z', 'k', '\a', '\x15', 
		'\x2', '\x2', '[', '\\', '\a', '\x5', '\x2', '\x2', '\\', ']', '\a', '\x1B', 
		'\x2', '\x2', ']', '^', '\a', '\x16', '\x2', '\x2', '^', '_', '\a', '\t', 
		'\x2', '\x2', '_', 'k', '\a', '\x15', '\x2', '\x2', '`', '\x61', '\a', 
		'\x6', '\x2', '\x2', '\x61', '\x62', '\a', '\x1B', '\x2', '\x2', '\x62', 
		'\x63', '\a', '\x16', '\x2', '\x2', '\x63', '\x64', '\a', '\n', '\x2', 
		'\x2', '\x64', 'k', '\a', '\x15', '\x2', '\x2', '\x65', '\x66', '\a', 
		'\a', '\x2', '\x2', '\x66', 'g', '\a', '\x1B', '\x2', '\x2', 'g', 'h', 
		'\a', '\x16', '\x2', '\x2', 'h', 'i', '\a', '\v', '\x2', '\x2', 'i', 'k', 
		'\a', '\x15', '\x2', '\x2', 'j', 'K', '\x3', '\x2', '\x2', '\x2', 'j', 
		'V', '\x3', '\x2', '\x2', '\x2', 'j', '[', '\x3', '\x2', '\x2', '\x2', 
		'j', '`', '\x3', '\x2', '\x2', '\x2', 'j', '\x65', '\x3', '\x2', '\x2', 
		'\x2', 'k', '\r', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\a', '\x1B', 
		'\x2', '\x2', 'm', 'n', '\a', '\x16', '\x2', '\x2', 'n', 'o', '\x5', '\x16', 
		'\f', '\x2', 'o', 's', '\a', '\x15', '\x2', '\x2', 'p', 'r', '\x5', '\x4', 
		'\x3', '\x2', 'q', 'p', '\x3', '\x2', '\x2', '\x2', 'r', 'u', '\x3', '\x2', 
		'\x2', '\x2', 's', 'q', '\x3', '\x2', '\x2', '\x2', 's', 't', '\x3', '\x2', 
		'\x2', '\x2', 't', '\xF', '\x3', '\x2', '\x2', '\x2', 'u', 's', '\x3', 
		'\x2', '\x2', '\x2', 'v', 'y', '\a', '\x1B', '\x2', '\x2', 'w', 'y', '\x5', 
		'\x14', '\v', '\x2', 'x', 'v', '\x3', '\x2', '\x2', '\x2', 'x', 'w', '\x3', 
		'\x2', '\x2', '\x2', 'y', 'z', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\a', 
		'\xE', '\x2', '\x2', '{', '\x83', '\x5', '\x16', '\f', '\x2', '|', '}', 
		'\a', '\x1B', '\x2', '\x2', '}', '\x83', '\a', '\xF', '\x2', '\x2', '~', 
		'\x7F', '\a', '\x11', '\x2', '\x2', '\x7F', '\x80', '\x5', '\x10', '\t', 
		'\x2', '\x80', '\x81', '\a', '\x12', '\x2', '\x2', '\x81', '\x83', '\x3', 
		'\x2', '\x2', '\x2', '\x82', 'x', '\x3', '\x2', '\x2', '\x2', '\x82', 
		'|', '\x3', '\x2', '\x2', '\x2', '\x82', '~', '\x3', '\x2', '\x2', '\x2', 
		'\x83', '\x11', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\t', '\x2', 
		'\x2', '\x2', '\x85', '\x13', '\x3', '\x2', '\x2', '\x2', '\x86', '\x87', 
		'\t', '\x3', '\x2', '\x2', '\x87', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x88', '\x8C', '\a', '\x1B', '\x2', '\x2', '\x89', '\x8C', '\x5', '\x14', 
		'\v', '\x2', '\x8A', '\x8C', '\x5', '\x10', '\t', '\x2', '\x8B', '\x88', 
		'\x3', '\x2', '\x2', '\x2', '\x8B', '\x89', '\x3', '\x2', '\x2', '\x2', 
		'\x8B', '\x8A', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x17', '\x3', '\x2', 
		'\x2', '\x2', '\x11', '\x1B', '!', '&', '/', '\x35', ':', '<', '\x44', 
		'I', 'Q', 'j', 's', 'x', '\x82', '\x8B',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
