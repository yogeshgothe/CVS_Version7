Imports System
Imports System.Data
    Imports System.Globalization
    Imports System.IO
    Imports System.Reflection
    Imports System.Xml
Imports Ionic.Zip



Namespace ODCWORK
    Friend NotInheritable Class OdsReaderWriter
        Private Shared namespaces As String(,) = New String(,) {
        {"table", "urn:oasis:names:tc:opendocument:xmlns:table:1.0"},
        {"office", "urn:oasis:names:tc:opendocument:xmlns:office:1.0"},
        {"style", "urn:oasis:names:tc:opendocument:xmlns:style:1.0"},
        {"text", "urn:oasis:names:tc:opendocument:xmlns:text:1.0"},
        {"draw", "urn:oasis:names:tc:opendocument:xmlns:drawing:1.0"},
        {"fo", "urn:oasis:names:tc:opendocument:xmlns:xsl-fo-compatible:1.0"},
        {"dc", "http://purl.org/dc/elements/1.1/"},
        {"meta", "urn:oasis:names:tc:opendocument:xmlns:meta:1.0"},
        {"number", "urn:oasis:names:tc:opendocument:xmlns:datastyle:1.0"},
        {"presentation", "urn:oasis:names:tc:opendocument:xmlns:presentation:1.0"},
        {"svg", "urn:oasis:names:tc:opendocument:xmlns:svg-compatible:1.0"},
        {"chart", "urn:oasis:names:tc:opendocument:xmlns:chart:1.0"},
        {"dr3d", "urn:oasis:names:tc:opendocument:xmlns:dr3d:1.0"},
        {"math", "http://www.w3.org/1998/Math/MathML"},
        {"form", "urn:oasis:names:tc:opendocument:xmlns:form:1.0"},
        {"script", "urn:oasis:names:tc:opendocument:xmlns:script:1.0"},
        {"ooo", "http://openoffice.org/2004/office"},
        {"ooow", "http://openoffice.org/2004/writer"},
        {"oooc", "http://openoffice.org/2004/calc"},
        {"dom", "http://www.w3.org/2001/xml-events"},
        {"xforms", "http://www.w3.org/2002/xforms"},
        {"xsd", "http://www.w3.org/2001/XMLSchema"},
        {"xsi", "http://www.w3.org/2001/XMLSchema-instance"},
        {"rpt", "http://openoffice.org/2005/report"},
        {"of", "urn:oasis:names:tc:opendocument:xmlns:of:1.2"},
        {"rdfa", "http://docs.oasis-open.org/opendocument/meta/rdfa#"},
        {"config", "urn:oasis:names:tc:opendocument:xmlns:config:1.0"}}

        Private Function GetZipFile(ByVal stream As Stream) As ZipFile
            Try
                Return ZipFile.Read(stream)
            Catch ex As Exception
                MsgBox("GetZipFile :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function

        Private Function GetZipFile(ByVal inputFilePath As String) As ZipFile
            Try
                Return ZipFile.Read(inputFilePath)
            Catch ex As Exception
                MsgBox("GetZipFile :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function

        Private Function GetContentXmlFile(ByVal zipFile As ZipFile) As XmlDocument
            Try
                Dim contentZipEntry As ZipEntry = zipFile("content.xml")
                Dim contentStream As Stream = New MemoryStream()
                contentZipEntry.Extract(contentStream)
                contentStream.Seek(0, SeekOrigin.Begin)
                Dim contentXml As XmlDocument = New XmlDocument()
                contentXml.Load(contentStream)
                Return contentXml
            Catch ex As Exception
                MsgBox("GetContentXmlFile :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function

        Private Function InitializeXmlNamespaceManager(ByVal xmlDocument As XmlDocument) As XmlNamespaceManager
            Try
                Dim nmsManager As XmlNamespaceManager = New XmlNamespaceManager(xmlDocument.NameTable)

                For i As Integer = 0 To namespaces.GetLength(0) - 1
                    nmsManager.AddNamespace(namespaces(i, 0), namespaces(i, 1))
                Next

                Return nmsManager
            Catch ex As Exception
                MsgBox("InitializeXmlNamespaceManager :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function

        Public Function ReadOdsFile(ByVal inputFilePath As String) As DataSet
            Try
                Dim odsZipFile As ZipFile = Me.GetZipFile(inputFilePath)
                Dim contentXml As XmlDocument = Me.GetContentXmlFile(odsZipFile)
                Dim nmsManager As XmlNamespaceManager = Me.InitializeXmlNamespaceManager(contentXml)
                Dim odsFile As DataSet = New DataSet(Path.GetFileName(inputFilePath))

                For Each tableNode As XmlNode In Me.GetTableNodes(contentXml, nmsManager)
                    odsFile.Tables.Add(Me.GetSheet(tableNode, nmsManager))
                Next
                Return odsFile
            Catch ex As Exception
                MsgBox("ReadOdsFile :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function

        Private Function GetTableNodes(ByVal contentXmlDocument As XmlDocument, ByVal nmsManager As XmlNamespaceManager) As XmlNodeList
            Try
                Return contentXmlDocument.SelectNodes("/office:document-content/office:body/office:spreadsheet/table:table", nmsManager)
            Catch ex As Exception
                MsgBox("GetTableNodes :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function

        Private Function GetSheet(ByVal tableNode As XmlNode, ByVal nmsManager As XmlNamespaceManager) As DataTable
            Try
                Dim sheet As DataTable = New DataTable(tableNode.Attributes("table:name").Value)
                Dim rowNodes As XmlNodeList = tableNode.SelectNodes("table:table-row", nmsManager)
                Dim rowIndex As Integer = 0

                For Each rowNode As XmlNode In rowNodes
                    Me.GetRow(rowNode, sheet, nmsManager, rowIndex)
                Next

                Return sheet
            Catch ex As Exception
                MsgBox("GetSheet :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function

        Private Sub GetRow(ByVal rowNode As XmlNode, ByVal sheet As DataTable, ByVal nmsManager As XmlNamespaceManager, ByRef rowIndex As Integer)
            Try
                Dim rowsRepeated As XmlAttribute = rowNode.Attributes("table:number-rows-repeated")

                If rowsRepeated Is Nothing OrElse Convert.ToInt32(rowsRepeated.Value, CultureInfo.InvariantCulture) = 1 Then

                    While sheet.Rows.Count < rowIndex
                        sheet.Rows.Add(sheet.NewRow())
                    End While

                    Dim row As DataRow = sheet.NewRow()
                    Dim cellNodes As XmlNodeList = rowNode.SelectNodes("table:table-cell", nmsManager)
                    Dim cellIndex As Integer = 0

                    For Each cellNode As XmlNode In cellNodes
                        Me.GetCell(cellNode, row, nmsManager, cellIndex)
                    Next

                    sheet.Rows.Add(row)
                    rowIndex += 1
                Else
                    rowIndex += Convert.ToInt32(rowsRepeated.Value, CultureInfo.InvariantCulture)
                End If

                If sheet.Rows.Count = 0 Then
                    sheet.Rows.Add(sheet.NewRow())
                    sheet.Columns.Add()
                End If
            Catch ex As Exception
                MsgBox("GetRow :   " & ex.Message, , "Control Valve Sizing")
            End Try
        End Sub

        Private Sub GetCell(ByVal cellNode As XmlNode, ByVal row As DataRow, ByVal nmsManager As XmlNamespaceManager, ByRef cellIndex As Integer)
            Try
                Dim cellRepeated As XmlAttribute = cellNode.Attributes("table:number-columns-repeated")

                If cellRepeated Is Nothing Then
                    Dim sheet As DataTable = row.Table

                    While sheet.Columns.Count <= cellIndex
                        sheet.Columns.Add()
                    End While

                    row(cellIndex) = Me.ReadCellValue(cellNode)
                    cellIndex += 1
                Else
                    cellIndex += Convert.ToInt32(cellRepeated.Value, CultureInfo.InvariantCulture)

                End If
            Catch ex As Exception
                MsgBox("OdsReaderWriterGetCell :   " & ex.Message, , "Control Valve Sizing")
            End Try
        End Sub

        Private Function ReadCellValue(ByVal cell As XmlNode) As String
            Try
                Dim cellVal As XmlAttribute = cell.Attributes("office:value")

                If cellVal Is Nothing Then
                    Return If(String.IsNullOrEmpty(cell.InnerText), Nothing, cell.InnerText)
                Else
                    Return cellVal.Value
                End If
            Catch ex As Exception
                MsgBox("OdsReaderWriterReadCellValue :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function

        Public Sub WriteOdsFile(ByVal odsFile As DataSet, ByVal outputFilePath As String)
            Try
                Dim templateFile As ZipFile = Me.GetZipFile(AppDomain.CurrentDomain.BaseDirectory & "template.ods")
                Dim contentXml As XmlDocument = Me.GetContentXmlFile(templateFile)
                Dim nmsManager As XmlNamespaceManager = Me.InitializeXmlNamespaceManager(contentXml)
                Dim sheetsRootNode As XmlNode = Me.GetSheetsRootNodeAndRemoveChildrens(contentXml, nmsManager)

                For Each sheet As DataTable In odsFile.Tables
                    Me.SaveSheet(sheet, sheetsRootNode)
                Next

                Me.SaveContentXml(templateFile, contentXml)
                templateFile.Save(outputFilePath)
            Catch ex As Exception
                MsgBox("File is Open.", ex.Message)
            End Try

        End Sub

        Private Function GetSheetsRootNodeAndRemoveChildrens(ByVal contentXml As XmlDocument, ByVal nmsManager As XmlNamespaceManager) As XmlNode
            Try
                Dim tableNodes As XmlNodeList = Me.GetTableNodes(contentXml, nmsManager)
                Dim sheetsRootNode As XmlNode = tableNodes.Item(0).ParentNode

                For Each tableNode As XmlNode In tableNodes
                    sheetsRootNode.RemoveChild(tableNode)
                Next
                Return sheetsRootNode
            Catch ex As Exception
                MsgBox("OdsReaderWriterGetSheetsRootNodeAndRemoveChildern :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function

        Private Sub SaveSheet(ByVal sheet As DataTable, ByVal sheetsRootNode As XmlNode)
            Try
                Dim ownerDocument As XmlDocument = sheetsRootNode.OwnerDocument
                Dim sheetNode As XmlNode = ownerDocument.CreateElement("table:table", Me.GetNamespaceUri("table"))
                Dim sheetName As XmlAttribute = ownerDocument.CreateAttribute("table:name", Me.GetNamespaceUri("table"))
                sheetName.Value = sheet.TableName
                sheetNode.Attributes.Append(sheetName)
                Me.SaveColumnDefinition(sheet, sheetNode, ownerDocument)
                Me.SaveRows(sheet, sheetNode, ownerDocument)
                sheetsRootNode.AppendChild(sheetNode)
            Catch ex As Exception
                MsgBox("OdsReaderWriterSaveSheet   " & ex.Message, , "Control Valve Sizing")
            End Try

        End Sub

        Private Sub SaveColumnDefinition(ByVal sheet As DataTable, ByVal sheetNode As XmlNode, ByVal ownerDocument As XmlDocument)
            Try
                Dim columnDefinition As XmlNode = ownerDocument.CreateElement("table:table-column", Me.GetNamespaceUri("table"))
                Dim columnsCount As XmlAttribute = ownerDocument.CreateAttribute("table:number-columns-repeated", Me.GetNamespaceUri("table"))
                columnsCount.Value = sheet.Columns.Count.ToString(CultureInfo.InvariantCulture)
                columnDefinition.Attributes.Append(columnsCount)
                sheetNode.AppendChild(columnDefinition)
            Catch ex As Exception
                MsgBox("OdsReaderWriterSaveColumnDefinition :   " & ex.Message, , "Control Valve Sizing")
            End Try
        End Sub

        Private Sub SaveRows(ByVal sheet As DataTable, ByVal sheetNode As XmlNode, ByVal ownerDocument As XmlDocument)
            Try
                Dim rows As DataRowCollection = sheet.Rows

                For i As Integer = 0 To rows.Count - 1
                    Dim rowNode As XmlNode = ownerDocument.CreateElement("table:table-row", Me.GetNamespaceUri("table"))
                    Me.SaveCell(rows(i), rowNode, ownerDocument)
                    sheetNode.AppendChild(rowNode)
                Next
            Catch ex As Exception
                MsgBox("OdsReaderWriterSaveRows :   " & ex.Message, , "Control Valve Sizing")
            End Try
        End Sub

        Private Sub SaveCell(ByVal row As DataRow, ByVal rowNode As XmlNode, ByVal ownerDocument As XmlDocument)
            Try
                Dim cells As Object() = row.ItemArray

                For i As Integer = 0 To cells.Length - 1
                    Dim cellNode As XmlElement = ownerDocument.CreateElement("table:table-cell", Me.GetNamespaceUri("table"))

                    If Not IsDBNull(row(i)) Then
                        Dim valueType As XmlAttribute = ownerDocument.CreateAttribute("office:value-type", Me.GetNamespaceUri("office"))
                        valueType.Value = "string"
                        cellNode.Attributes.Append(valueType)
                        Dim cellValue As XmlElement = ownerDocument.CreateElement("text:p", Me.GetNamespaceUri("text"))
                        cellValue.InnerText = row(i).ToString()
                        cellNode.AppendChild(cellValue)
                    End If
                    rowNode.AppendChild(cellNode)
                Next
            Catch ex As Exception
                MsgBox("OdsReaderWriterSaveCell :   " & ex.Message, , "Control Valve Sizing")
            End Try
        End Sub

        Private Sub SaveContentXml(ByVal templateFile As ZipFile, ByVal contentXml As XmlDocument)
            Try
                templateFile.RemoveEntry("content.xml")
                Dim memStream As MemoryStream = New MemoryStream()
                contentXml.Save(memStream)
                memStream.Seek(0, SeekOrigin.Begin)
                templateFile.AddEntry("content.xml", memStream)
            Catch ex As Exception
                MsgBox("OdsReaderWriterSaveContentXml :   " & ex.Message, , "Control Valve Sizing")
            End Try

        End Sub

        Private Function GetNamespaceUri(ByVal prefix As String) As String
            Try
                For i As Integer = 0 To namespaces.GetLength(0) - 1
                    If namespaces(i, 0) = prefix Then Return namespaces(i, 1)
                Next
                Throw New InvalidOperationException("Can't find that namespace URI")
            Catch ex As Exception
                MsgBox("OdsReaderWriterGetNamespaceUri :   " & ex.Message, , "Control Valve Sizing")
                Return Nothing
            End Try
        End Function
    End Class
End Namespace



