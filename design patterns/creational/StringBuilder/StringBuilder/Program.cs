using Builder;
using StringBuilder;
using StringBuilder.Entities;

#region HtmlBuilder

//HtmlElement root = HtmlElement.Create("ul")
//    .AddChild("li", "mohamed")
//    .AddChild("li", "ali");

//Console.WriteLine(root);
#endregion

#region Composite Builder

Person person = Person.Create().
    Works.
    WorksOn("Facebook").
    InPosition("SW").
    WithAnnualSalary(90000)
    .Lives.
    LivesOn("New Jersey").
    WithAddress("st 5 ").
    OwnPostCode("08989");
Console.WriteLine(person);

#endregion