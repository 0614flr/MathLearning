using System.Xml;
using Xmllearning;

internal class MyClass
{
    public static void Main(string[] args)
    {
        var skillList = new List<Skill>(); //创建技能集合，储存所有的技能信息

        var xmlDocument = new XmlDocument();
        xmlDocument.Load("skill.xml");
        //得到根节点
        var rootNode = xmlDocument.FirstChild; //获取第一个节点
        //得到根节点下面子节点的集合
        var skillNodeList = rootNode.ChildNodes;
        foreach (XmlNode skillNode in skillNodeList)
        {
            var skill = new Skill();
        }
    }
}