using Algorithms.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Xml;
using static Algorithms.Strings.XmlTree;

namespace Algorithms.Strings
{
    //    public class XmlTree
    //    {
    //        public enum XmlElementType
    //        {
    //            ELEMENT_UNKNOWN = 1,
    //            ELEMENT_OPENING_TAG = 2,
    //            ELEMENT_CLOSING_TAG = 3,
    //            ELEMENT_TEXT = 4
    //        };

    //        public  class XmlElement
    //        {
    //            public XmlElementType element_type;
    //            public string node_name;
    //            public XmlElement()
    //            {
    //                this.element_type = XmlElementType.ELEMENT_UNKNOWN;
    //                this.node_name = "";
    //            }
    //        }

    //        public class XmlTokenizer
    //        {
    //            public string xml;
    //            public int current_index;

    //            public XmlTokenizer(string xml_str)
    //            {
    //                this.xml = xml_str;
    //                this.current_index = 0;
    //            }

    //            public  bool getNextElement(XmlElement element)
    //            {
    //                int i = this.xml.Substring(this.current_index).IndexOf('<');

    //                if (i == -1)
    //                {
    //                    return false;
    //                }
    //                i += this.current_index;

    //                string temp = this.xml.Substring(this.current_index, i);
    //                temp = temp.Trim();

    //                if (temp.Length != 0)
    //                {
    //                    element.node_name = temp;
    //                    element.element_type = XmlElementType.ELEMENT_TEXT;

    //                    this.current_index += i;
    //                    return true;
    //                }

    //                int j = this.xml.Substring(i).IndexOf(">");
    //                j += i;
    //                if (this.xml[i + 1] == '/')
    //                {
    //                    element.node_name = this.xml.Substring(i + 2, j);
    //                    element.element_type = XmlElementType.ELEMENT_CLOSING_TAG;
    //                }
    //                else
    //                {
    //                    element.node_name = this.xml.Substring(i + 1, j);
    //                    element.element_type = XmlElementType.ELEMENT_OPENING_TAG;
    //                }
    //                this.current_index = j + 1;
    //                return true;
    //            }
    //        }
    //        public class Node_xml
    //        {
    //            public string node_name;
    //            public List<Node_xml> Children;

    //            public Node_xml(string name)
    //            {
    //                this.node_name = name;
    //                this.Children = new List<Node_xml>();
    //            }
    //        }

    //        static Node_xml createXmlTree(string xml)
    //        {

    //            XmlTokenizer tok = new XmlTokenizer(xml);
    //            XmlElement element = new XmlElement();

    //            if (!tok.getNextElement(element))
    //            {
    //                return null;
    //            }


    //            Stack<Node_xml> st = new Stack<Node_xml>();
    //            Node_xml root = new Node_xml(element.node_name);
    //            st.Push(root);

    //            while (tok.getNextElement(element))
    //            {
    //                Node_xml n = null;
    //                if (element.element_type == XmlElementType.ELEMENT_OPENING_TAG || element.element_type == XmlElementType.ELEMENT_TEXT)
    //                {
    //                    n = new Node_xml(element.node_name);
    //                    ///TODO
    //                    //st.children.push(n);
    //                }

    //                if (element.element_type == XmlElementType.ELEMENT_OPENING_TAG)
    //                {
    //                    st.Push(n);
    //                }
    //                else if (element.element_type == XmlElementType.ELEMENT_CLOSING_TAG)
    //                {
    //                    st.Pop();
    //                }
    //            }

    //            return root;
    //        }


    //        public static void print_tree(Node_xml root, int depth)
    //        {
    //            if (root == null)
    //            {
    //                return;
    //            }

    //            for (int i = 0; i < depth; ++i) Console.WriteLine("\t");
    //            Console.WriteLine(root.node_name + "\n");

    //            foreach (Node_xml child in root.Children)
    //            {
    //                print_tree(child, depth + 1);
    //            }
    //        }

    //        public static void Execute()
    //        {
    //            try
    //            {
    //                String xml = "<xml><data>hello world     </data>    <a><b></b><b><c></c></b></a></xml>";
    //                Node_xml result = createXmlTree(xml);
    //                print_tree(result, 0);
    //            }
    //            catch (Exception ex)
    //            {
    //                throw ex;
    //            }
    //        }
    //    }
    //}

    class XmlTree
    {
        public class Node_xml
        {
            public string node_name;
            public List<Node_xml> Children;

            public Node_xml(string name)
            {
                this.node_name = name;
                this.Children = new List<Node_xml>();
            }
        }

        public static Node_xml createXmlTree(String xml)
        {
            XmlTextReader reader = new XmlTextReader(new StringReader(xml));

            Stack<Node_xml> stack = new Stack<Node_xml>();

            Node_xml last = null;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Whitespace)
                {
                    continue;
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    if (stack.Count != 0)
                    {
                        last = stack.Pop();
                    }
                    continue;
                }

                if (reader.NodeType == XmlNodeType.Element)
                {
                    Node_xml node = new Node_xml(reader.Name);

                    if (stack.Count!=0)
                    {
                        stack.Peek().Children.Add(node);
                    }

                    stack.Push(node);
                }
                else if (reader.NodeType == XmlNodeType.Text)
                {
                    Node_xml node = new Node_xml(reader.Value);

                    if (stack.Count != 0)
                    {
                        stack.Peek().Children.Add(node);
                    }
                }
            }
            return last;
        }
        public static void print_tree(Node_xml root, int depth)
        {
            if (root == null)
            {
                return;
            }

            for (int i = 0; i < depth; ++i) Console.Write("\t");
            Console.WriteLine(root.node_name +" ");

            foreach (Node_xml child in root.Children)
            {
                print_tree(child, depth + 1);
            }
        }

        public static void Execute()
        {
            try
            {
                String xml = "<xml><data>hello world     </data>    <a><b></b><c></c></a></xml>";
                Node_xml result = createXmlTree(xml);
                Console.WriteLine(xml);
                print_tree(result, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}


