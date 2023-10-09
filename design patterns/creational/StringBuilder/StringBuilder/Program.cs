using Builder;
using StringBuilder;
using StringBuilder.Builders;
using StringBuilder.Entities;

#region HtmlBuilder

//HtmlElement root = HtmlElement.Create("ul")
//    .AddChild("li", "mohamed")
//    .AddChild("li", "ali");

//Console.WriteLine(root);
#endregion

#region Composite Builder

//Person person = Person.Create().
//    Works.
//    WorksOn("Facebook").
//    InPosition("SW").
//    WithAnnualSalary(90000)
//    .Lives.
//    LivesOn("New Jersey").
//    WithAddress("st 5 ").
//    OwnPostCode("08989");
//Console.WriteLine(person);

#endregion

#region 
var Builder = new ExpenseBuilder().Build()
    .AddMyVat(10)
    .AddEmployee("mohamed", 4500, 3123123, 1, true)
    .AddEmployee("Amir", 3500, 3123123, 1, true)
    .AddEmployee("amr", 5500, 3123123, 1, true);
Console.WriteLine(Builder);

    #endregion