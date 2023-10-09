using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TiledMapper.Xml
{
    public class XmlMapperException : Exception
    {
        public readonly string Text;
        public XmlMapperException(string text)
            : base()
        {
            Text = text;
        }
    }

    public static class XmlExtension
    {
        public static bool TryGetBoolAttribute(this XmlElement el, string name)
        {
            if (!el.HasAttribute(name)) return false;
            string attr = el.GetAttribute(name);
            return XmlConvert.ToBoolean(attr);
        }

        public static bool GetBoolAttribute(this XmlElement el, string name)
        {
            assertAttribute(el, name);
            string attr = el.GetAttribute(name);
            return XmlConvert.ToBoolean(attr);
        }

        public static int GetIntAttribute(this XmlElement el, string name)
        {
            assertAttribute(el, name);
            string attr = el.GetAttribute(name);
            return XmlConvert.ToInt32(attr);
        }

        public static XmlElement ToElement(this XmlNode n)
        {
            if (n.NodeType != XmlNodeType.Element) throw new XmlMapperException("node '" + n.Name + "' is not an element type");
            return n as XmlElement;
        }

        public static XmlElement TryToElement(this XmlNode n)
        {
            if (n.NodeType != XmlNodeType.Element) return null;
            return n as XmlElement;
        }

        public static XmlElement FirstChildElement(this XmlElement el, string s)
        {
            XmlNodeList nl = el.GetElementsByTagName(s);
            for (int i = 0; i < nl.Count; i++)
            {
                XmlElement ret = nl.Item(i).ToElement();
                if (ret != null) return ret;
            }

            throw new XmlMapperException("element '" + el.Name + "' does not contain subelement '" + s + "'");
        }

        private static void assertAttribute(XmlElement el, string name)
        {
            if (!el.HasAttribute(name)) throw new XmlMapperException("attribute '" + name + "' not found in element '" + el.Name + "'");
        }
    }
}
