using StringBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Builder
{
    public record HtmlElement (string name,string text)
    {
        public string Name = name;
        public string Text = text;
        private readonly Lazy<List<HtmlElement>> elements = new();//singleton
        public List<HtmlElement> Elements => elements.Value;//children
        private const int indentSize = 2;//text indent
        public HtmlElement() : this("", "") { }
        public override string ToString() => renderElement(0);

        private string renderElement(int indent)
        {
            var sb = new System.Text.StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.Append($"{i}<{Name}>\n");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.Append(Text);
                sb.Append('\n');
            }
            foreach (var e in Elements)
                sb.Append(e.renderElement(indent + 1));
            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();

        }

        public static HtmlBuilder Create(string name) => new HtmlBuilder(name);//factory method


    }
}
