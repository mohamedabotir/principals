using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
   public class HtmlBuilder
    {
        protected readonly string rootName;
        protected HtmlElement root = new HtmlElement();
        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }
        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }
        public override string ToString() => root.ToString();

        public static implicit operator HtmlElement(HtmlBuilder builder)
        {
            return builder.root;
        }
    }

}
