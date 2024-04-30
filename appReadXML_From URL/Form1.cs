using System.Xml;

namespace appReadXML_From_URL
{
  public partial class Form1 : Form
  {
    String URLString;
    XmlTextReader reader;
    public Form1()
    {
      InitializeComponent();
      URLString = "https://www.w3schools.com/xml/cd_catalog.xml";
      reader = new XmlTextReader(URLString);
      while (reader.Read())
      {
        switch (reader.NodeType)
        {
          case XmlNodeType.Element: // The node is an element.
            txtXMLData.Text +=("<" + reader.Name);

            while (reader.MoveToNextAttribute()) // Read the attributes.
              txtXMLData.Text +=(" " + reader.Name + "='" + reader.Value + "'");
            //txtXMLData.Text +=(">");
            txtXMLData.Text +=(">")+ Environment.NewLine;
            break;
          case XmlNodeType.Text: //Display the text in each element.
            txtXMLData.Text +=(reader.Value) + Environment.NewLine;
            break;
          case XmlNodeType.EndElement: //Display the end of the element.
            txtXMLData.Text +=("</" + reader.Name);
            txtXMLData.Text +=(">") + Environment.NewLine;
            break;
        }
      }

    }
  }
}
