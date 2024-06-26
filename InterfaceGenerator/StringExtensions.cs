namespace Speckle.InterfaceGenerator;

internal static class StringExtensions
{
    public static bool IsCSharpKeyword(string? name)
    {
        switch (name)
        {
            case "abstract":
            case "add":
            case "alias":
            case "as":
            case "ascending":
            case "async":
            case "await":
            case "base":
            case "bool":
            case "break":
            case "by":
            case "byte":
            case "case":
            case "catch":
            case "char":
            case "checked":
            case "class":
            case "const":
            case "continue":
            case "decimal":
            case "default":
            case "delegate":
            case "descending":
            case "do":
            case "double":
            case "dynamic":
            case "else":
            case "enum":
            case "equals":
            case "event":
            case "explicit":
            case "extern":
            case "false":
            case "finally":
            case "fixed":
            case "float":
            case "for":
            case "foreach":
            case "from":
            case "get":
            case "global":
            case "goto":
            // `group` is a contextual to linq queries that we don't generate
            //case "group":
            case "if":
            case "implicit":
            case "in":
            case "int":
            case "interface":
            case "internal":
            case "into":
            case "is":
            case "join":
            case "let":
            case "lock":
            case "long":
            case "nameof":
            case "namespace":
            case "new":
            case "null":
            case "object":
            case "on":
            case "operator":
            // `orderby` is a contextual to linq queries that we don't generate
            //case "orderby":
            case "out":
            case "override":
            case "params":
            case "partial":
            case "private":
            case "protected":
            case "public":
            case "readonly":
            case "ref":
            case "remove":
            case "return":
            case "sbyte":
            case "sealed":
            // `select` is a contextual to linq queries that we don't generate
            // case "select":
            case "set":
            case "short":
            case "sizeof":
            case "stackalloc":
            case "static":
            case "string":
            case "struct":
            case "switch":
            case "this":
            case "throw":
            case "true":
            case "try":
            case "typeof":
            case "uint":
            case "ulong":
            case "unchecked":
            case "unmanaged":
            case "unsafe":
            case "ushort":
            case "using":
            // `value` is a contextual to getters that we don't generate
            // case "value":
            case "var":
            case "virtual":
            case "void":
            case "volatile":
            case "when":
            case "where":
            case "while":
            case "yield":
                return true;
            default:
                return false;
        }
    }
}