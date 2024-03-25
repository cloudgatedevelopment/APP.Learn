//
//1. Query Syntax (SQL-like syntax)
//
//var query = from item in collection
//            where condition
//            select item;

//2. Method Syntax (fluent interface):
//
//var query = collection
//            .Where(item => condition)
//            .Select(item => item);

//Mixed Syntax (combination of query and method syntax):
//var query = (from item in collection
//             where condition
//             select item).ToList();
// OR
// var query = collection
//.Where(item => condition)
//.Select(item => item)
//.ToList();


using APP.Core;
using APP.Core._1;
using APP.Core.HW._1;

Syntax syntax = new Syntax();
syntax.MethodSyntax();

//SyntaxWhere syntaxWhere = new SyntaxWhere();
//syntaxWhere.Example();

//SyntaxWhereHW syntaxWhereHW = new SyntaxWhereHW();
//syntaxWhereHW.Example();
Console.ReadKey();