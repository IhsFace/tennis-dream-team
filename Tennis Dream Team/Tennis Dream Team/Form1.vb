Imports System.Xml

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strName As String = txtName.Text
        Dim strCountry As String = txtCountry.Text
        Dim strBirthDate As String = txtBirthDate.Text

        Dim writer As New XmlTextWriter("TennisPlayers.xml", System.Text.Encoding.UTF8)

        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Records")

        CreateXMLRec(strName, strCountry, strBirthDate, writer)

        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()

        MessageBox.Show("Player Record Saved Successfully.")
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim strName As String
        Dim strCountry As String
        Dim strBirthDate As String

        Dim m_xmld As XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode

        m_xmld = New XmlDocument
        m_xmld.Load("TennisPlayers.xml")
        m_nodelist = m_xmld.GetElementsByTagName("Player")

        For Each m_node In m_nodelist
            strName = m_node.Item("Name").InnerText
            strCountry = m_node.Item("Country").InnerText
            strBirthDate = m_node.Item("BirthDate").InnerText

            lstNames.Items.Add(strName)
            lstCountries.Items.Add(strCountry)
            lstBirthDates.Items.Add(strBirthDate)
        Next
    End Sub

    Private Function CreateXMLRec(ByVal IncomingName As String, ByVal IncomingCountry As String, ByVal IncomingBirthDate As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Player")

        writer.WriteStartElement("Name")
        writer.WriteString(IncomingName)
        writer.WriteEndElement()

        writer.WriteStartElement("Country")
        writer.WriteString(IncomingCountry)
        writer.WriteEndElement()

        writer.WriteStartElement("BirthDate")
        writer.WriteString(IncomingBirthDate)
        writer.WriteEndElement()

        writer.WriteEndElement()
    End Function
End Class
