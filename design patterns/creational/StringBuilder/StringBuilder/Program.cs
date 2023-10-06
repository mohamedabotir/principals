using Builder;
using StringBuilder;

HtmlElement root = HtmlElement.Create("ul")
    .AddChild("li", "mohamed")
    .AddChild("li", "ali");

Console.WriteLine(root);
 