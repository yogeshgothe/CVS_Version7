Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

'Imports System.Data.OracleClient

Public Class Form1

    'Declaring dataset ds
    Dim ds As New DataSet

    'Function to check Internet Connection
    Public Function HaveInternetConnection() As Boolean

        Try
            My.Computer.Network.Ping("www.google.com")
            MessageBox.Show("Internet Connection Status: CONNECTED")
            Return True
        Catch
            MessageBox.Show("Internet Connection Status: NOT CONNECTED")
            Return False
        End Try


    End Function

    'Function To Update SQL Tables {LOCAL DB} With Data From Oracle Tables {MAIN DB}
    <Obsolete>
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

        Dim internet As Boolean = HaveInternetConnection()

        If internet = False Then
            MessageBox.Show("Connect To Internet To Update SQL Data Tables")
            Exit Sub
        End If

        Dim ods As New DataSet

        'Connection to Oracle Database {Connecting to SQL for testing}
        Dim constr As String = "Data Source=.\SQLEXPRESS;Initial Catalog=test;Integrated Security=true"
        Dim conn As SqlConnection
        Dim commands As SqlCommand
        Dim adapters As New SqlDataAdapter

        'Queries for Oracle Tables    {Will Remain Same For Oracle also}
        Dim ones As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '3' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim twos As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '3' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim threes As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '6' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim fours As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '6' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim fives As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '4' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim sixs As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '4' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim sevens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '5' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim eights As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '5' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim nines As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '7' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim tens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '7' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim elevens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '13' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim twelves As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '13' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim thirteens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '10' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim fourteens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '10' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim fifteens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '8' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim sixteens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '8' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim seventeens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '12' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim eighteens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '12' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim nineteens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '11' AND PPVM_PARAMETER_CODE = '2' ORDER BY PPVM_PARAMETER_VALUE"
        Dim twentys As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '11' AND PPVM_PARAMETER_CODE = '3' ORDER BY PPVM_PARAMETER_VALUE"
        Dim twentyones As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '10' ORDER BY PPVM_PARAMETER_VALUE"
        Dim twentytwos As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"
        Dim twentythrees As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '13' ORDER BY PPVM_PARAMETER_VALUE"
        Dim twentyfours As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '11' ORDER BY PPVM_PARAMETER_VALUE"
        Dim twentyfives As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"
        Dim twentysixs As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '81' AND PPVM_PARAMETER_CODE = '8' ORDER BY PPVM_PARAMETER_VALUE"
        'Dim twentysevens As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS SR_NOS,PPVM_MODEL_NO,PPVM_CATEGORY_CODE,PPVM_PARAMETER_CODE,PPVM_PARAMETER_VALUE_CODE,PPVM_PARAMETER_VALUE,PPVM_SHORT_DESC,CREATION_DATE,CREATED_BY,LAST_UPDATED_DATE,LAST_UPDATED_BY FROM Parameter_Value WHERE PPVM_MODEL_NO = '1000' AND PPVM_CATEGORY_CODE = '16' AND PPVM_PARAMETER_CODE = '12' ORDER BY PPVM_PARAMETER_VALUE"

        conn = New SqlConnection(constr)

        'To fill ods DataSet that contains the data from oracle tables
        Try

            'Positioner Make Table
            commands = New SqlCommand(ones, conn)
            adapters.SelectCommand = commands
            adapters.Fill(ods, "AAPOSITIONERMAKE")

            'Positioner Models Table
            adapters.SelectCommand.CommandText = twos
            adapters.Fill(ods, "AAPOSITIONER")

            'SOV Make Table
            adapters.SelectCommand.CommandText = threes
            adapters.Fill(ods, "AASOVMAKE")

            'SOV Models Table
            adapters.SelectCommand.CommandText = fours
            adapters.Fill(ods, "AASOV")

            'AFR Make Table
            adapters.SelectCommand.CommandText = fives
            adapters.Fill(ods, "AAFRMAKE")

            'AFR Models Table
            adapters.SelectCommand.CommandText = sixs
            adapters.Fill(ods, "AAFR")

            'ALR Make Table
            adapters.SelectCommand.CommandText = sevens
            adapters.Fill(ods, "AALRMAKE")

            'ALR Models Table
            adapters.SelectCommand.CommandText = eights
            adapters.Fill(ods, "AALR")

            'LIMITSWITCH Make Table
            adapters.SelectCommand.CommandText = nines
            adapters.Fill(ods, "AALIMITSWITCHMAKE")

            'LIMITSWITCH Models Table
            adapters.SelectCommand.CommandText = tens
            adapters.Fill(ods, "AALIMITSWITCH")

            'VOLBOOSTER Make Table
            adapters.SelectCommand.CommandText = elevens
            adapters.Fill(ods, "AAVOLBOOSTERMAKE")

            'VOLBOOSTER Models Table
            adapters.SelectCommand.CommandText = twelves
            adapters.Fill(ods, "AAVOLBOOSTER")

            'QEV Make Table
            adapters.SelectCommand.CommandText = thirteens
            adapters.Fill(ods, "AAQEVMAKE")

            'QEV Models Table
            adapters.SelectCommand.CommandText = fourteens
            adapters.Fill(ods, "AAQEV")

            'POSTRANS Make Table
            adapters.SelectCommand.CommandText = fifteens
            adapters.Fill(ods, "AAPOSTRANSMAKE")

            'POSTRANS Models Table
            adapters.SelectCommand.CommandText = sixteens
            adapters.Fill(ods, "AAPOSTRANS")

            'ROBOTOR Make Table
            adapters.SelectCommand.CommandText = seventeens
            adapters.Fill(ods, "AAROBOTORMAKE")

            'ROBOTOR Models Table
            adapters.SelectCommand.CommandText = eighteens
            adapters.Fill(ods, "AAROBOTOR")

            'ITOP Make Table
            adapters.SelectCommand.CommandText = nineteens
            adapters.Fill(ods, "AAITOPMAKE")

            'ITOP Models Table
            adapters.SelectCommand.CommandText = twentys
            adapters.Fill(ods, "AAITOP")

            'BodyMat Table
            adapters.SelectCommand.CommandText = twentyones
            adapters.Fill(ods, "AABODYMAT")

            'Plug Table
            adapters.SelectCommand.CommandText = twentytwos
            adapters.Fill(ods, "AAPLUG")

            'GasketMat Table
            adapters.SelectCommand.CommandText = twentythrees
            adapters.Fill(ods, "AAGASKETMAT")

            'TopMat Table
            adapters.SelectCommand.CommandText = twentyfours
            adapters.Fill(ods, "AATOPMAT")

            'Seat Table
            adapters.SelectCommand.CommandText = twentyfives
            adapters.Fill(ods, "AASEAT")

            'Attenuation Table
            adapters.SelectCommand.CommandText = twentysixs
            adapters.Fill(ods, "AATTENUATION")

            'Painting Body Table
            'adapters.SelectCommand.CommandText = twentysevens
            'adapters.Fill(ods, "AAPAINT_BODY")

            'Dispose After Use
            adapters.Dispose()
            commands.Dispose()
            conn.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error while Filling DataSet with Oracle Tables")
        End Try

        'Connecting to SQL Server to upload the data
        Dim constrr As String = "Data Source=.\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=true;"


        Dim i As Integer
        For i = 0 To ods.Tables.Count - 1

            'If table is not empty then update
            If ods.Tables(i).Rows.Count > 0 Then

                'First Delete existing Records:
                Dim connect As New SqlConnection
                Dim cmd As New SqlCommand
                Try
                    connect.ConnectionString = constrr
                    connect.Open()
                    cmd.Connection = connect
                    cmd.CommandText = "delete from " + ods.Tables(i).ToString() + " where model_code is not null"
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error While Deleting Existing Records")
                End Try

                'Put new records in the same table
                Using con As New SqlConnection(constrr)

                    Using copy As New SqlBulkCopy(con)
                        copy.DestinationTableName = "dbo." + ods.Tables(i).ToString() + ""

                        copy.ColumnMappings.Add("SR_NOS", "SR_NO")
                        copy.ColumnMappings.Add("PPVM_MODEL_NO", "MODEL_CODE")
                        copy.ColumnMappings.Add("PPVM_CATEGORY_CODE", "CATEGORY_CODE")
                        copy.ColumnMappings.Add("PPVM_PARAMETER_CODE", "PARAMETER_CODE")
                        copy.ColumnMappings.Add("PPVM_PARAMETER_VALUE_CODE", "PARAMETER_VALUE_CODE")
                        copy.ColumnMappings.Add("PPVM_PARAMETER_VALUE", "PARAMETER_VALUE")
                        copy.ColumnMappings.Add("PPVM_SHORT_DESC", "PARAMETER_DESC")
                        copy.ColumnMappings.Add("CREATION_DATE", "CREATION_DATE")
                        copy.ColumnMappings.Add("CREATED_BY", "CREATED_BY")
                        copy.ColumnMappings.Add("LAST_UPDATED_DATE", "UPDATED_DATE")
                        copy.ColumnMappings.Add("LAST_UPDATED_BY", "UPDATED_BY")

                        con.Open()
                        copy.WriteToServer(ods.Tables(i))
                        con.Close()
                    End Using
                End Using

            End If
        Next
        'Displaying Number Of Tables Updated
        MessageBox.Show("Updated " + (ods.Tables.Count).ToString() + " Tables")
    End Sub

    'Loading Dataset With Data From SQL DB {Local Tables} into the DataSet 'ds' and then the ComboBoxes
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load


        'ComboBox4.AutoCompleteMode = AutoCompleteMode.Suggest
        'ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        'ComboBox4.AutoCompleteSource = AutoCompleteSource.ListItems
        'ComboBox4.DroppedDown = False

        'ComboBox5.AutoCompleteMode = AutoCompleteMode.Suggest
        'ComboBox5.DropDownStyle = ComboBoxStyle.DropDown
        'ComboBox5.AutoCompleteSource = AutoCompleteSource.ListItems
        'ComboBox5.DroppedDown = True

        'Connection to Server and Database
        Dim constr As String = "Data Source=.\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=true"
        Dim con As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter


        'Sql Queries
        Dim first As String = "select *,ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos from topbonnettype ORDER BY NAME;"   'This method generates serial numbers automatically even if the order of items changes and is also stored in the DataSet
        Dim second As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from endconnection ORDER BY NAME;"
        Dim third As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from bodymat ORDER BY NAME;"
        Dim four As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from plug ORDER BY NAME;"
        Dim five As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from seat ORDER BY NAME;"
        Dim six As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from topmat ORDER BY NAME;"
        Dim seven As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from gasketmat ORDER BY NAME;"
        Dim eight As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from painting ORDER BY NAME;"
        Dim nine As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from positioner ORDER BY NAME;"
        Dim ten As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from sov ORDER BY NAME;"
        Dim eleven As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from afr ORDER BY NAME;"
        Dim twelve As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from alr ORDER BY NAME;"
        Dim thirteen As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from limitswitchbox ORDER BY NAME;"
        Dim fourteen As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from volbooster ORDER BY NAME;"
        Dim fifteen As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from postrans ORDER BY NAME;"
        Dim sixteen As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from vtank ORDER BY NAME;"
        Dim seventeen As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from robotor ORDER BY NAME;"
        Dim eighteen As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from itop ORDER BY NAME;"
        Dim nineteen As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from qev ORDER BY NAME;"
        Dim twenty As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from certification ORDER BY NAME;"
        Dim twoone As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from handwheel ORDER BY NAME;"
        Dim twotwo As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from tubing ORDER BY NAME;"
        Dim twothree As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from guiding ORDER BY NAME;"
        Dim twofour As String = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,NAME FROM PositionerMake GROUP BY NAME; ;"
        Dim twofive As String = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,NAME FROM AfrMake GROUP BY NAME; ;"
        Dim twosix As String = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,NAME FROM AlrMake GROUP BY NAME; ;"
        Dim twoseven As String = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,NAME FROM SovMake GROUP BY NAME; ;"
        Dim twoeight As String = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,NAME FROM VbMake GROUP BY NAME; ;"
        Dim twonine As String = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,NAME FROM limitswitchmake GROUP BY NAME; ;"
        Dim thirty As String = "SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,NAME FROM qevmake GROUP BY NAME; ;"
        Dim threeone As String = "select distinct actuator_name_model, dense_rank() over (order by (select null)) as Sr_Nos from actuator ;"
        Dim threetwo As String = "select distinct valvesize_inches, dense_rank() over (order by (select null)) as Sr_Nos from ps1_ps3 ;"
        Dim threethree As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from fr ;"
        Dim threefour As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from fl ;"
        Dim threefive As String = "select distinct valve_size_inches, dense_rank() over (order by (select null)) as Sr_Nos from threewayvalve ;"
        Dim threesix As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from pipeschedule1 ;"
        Dim threeseven As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from pipeschedule2 ;"
        Dim threeeight As String = "select distinct valve_size_inches, dense_rank() over (order by (select null)) as Sr_Nos from kvforcage ;"
        Dim threenine As String = "select distinct valvesize, dense_rank() over (order by (select null)) as Sr_Nos from prtable ;"
        Dim forty As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from ratingclass ;"
        Dim fourone As String = "select ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS Sr_Nos,* from outputrecords ;"
        Dim fourtwo As String = "select * from storagerecords_gap ;"

        con = New SqlConnection(constr)

        Try
            con.Open()

            'Table 1
            command = New SqlCommand(first, con)
            adapter.SelectCommand = command
            adapter.Fill(ds, "topbonnettype")

            'Table 2
            adapter.SelectCommand.CommandText = second
            adapter.Fill(ds, "endconnection")

            'Table 3
            adapter.SelectCommand.CommandText = third
            adapter.Fill(ds, "bodymat")

            'Table 4
            adapter.SelectCommand.CommandText = four
            adapter.Fill(ds, "plug")

            'Table 5
            adapter.SelectCommand.CommandText = five
            adapter.Fill(ds, "seat")

            'Table 6
            adapter.SelectCommand.CommandText = six
            adapter.Fill(ds, "topmat")

            'Table 7
            adapter.SelectCommand.CommandText = seven
            adapter.Fill(ds, "gasketmat")

            'Table 8
            adapter.SelectCommand.CommandText = eight
            adapter.Fill(ds, "painting")

            'Table 9
            adapter.SelectCommand.CommandText = nine
            adapter.Fill(ds, "positioner")

            'Table 10
            adapter.SelectCommand.CommandText = ten
            adapter.Fill(ds, "sov")

            'Table 11
            adapter.SelectCommand.CommandText = eleven
            adapter.Fill(ds, "afr")

            'Table 12
            adapter.SelectCommand.CommandText = twelve
            adapter.Fill(ds, "alr")

            'Table 13
            adapter.SelectCommand.CommandText = thirteen
            adapter.Fill(ds, "limitswitchbox")

            'Table 14
            adapter.SelectCommand.CommandText = fourteen
            adapter.Fill(ds, "volbooster")

            'Table 15
            adapter.SelectCommand.CommandText = fifteen
            adapter.Fill(ds, "postrans")

            'Table 16
            adapter.SelectCommand.CommandText = sixteen
            adapter.Fill(ds, "vtank")

            'Table 17
            adapter.SelectCommand.CommandText = seventeen
            adapter.Fill(ds, "robotor")

            'Table 18
            adapter.SelectCommand.CommandText = eighteen
            adapter.Fill(ds, "itop")

            'Table 19
            adapter.SelectCommand.CommandText = nineteen
            adapter.Fill(ds, "qev")

            'Table 20
            adapter.SelectCommand.CommandText = twenty
            adapter.Fill(ds, "certification")

            'Table 21
            adapter.SelectCommand.CommandText = twoone
            adapter.Fill(ds, "handwheel")

            'Table 22
            adapter.SelectCommand.CommandText = twotwo
            adapter.Fill(ds, "tubing")

            'Table 23
            adapter.SelectCommand.CommandText = twothree
            adapter.Fill(ds, "guiding")

            'Table 24
            adapter.SelectCommand.CommandText = twofour
            adapter.Fill(ds, "positionermake")

            'Table 25
            adapter.SelectCommand.CommandText = twofive
            adapter.Fill(ds, "afrmake")

            'Table 26
            adapter.SelectCommand.CommandText = twosix
            adapter.Fill(ds, "alrmake")

            'Table 27
            adapter.SelectCommand.CommandText = twoseven
            adapter.Fill(ds, "sovmake")

            'Table 28
            adapter.SelectCommand.CommandText = twoeight
            adapter.Fill(ds, "vbmake")

            'Table 29
            adapter.SelectCommand.CommandText = twonine
            adapter.Fill(ds, "limitswitchmake")

            'Table 30
            adapter.SelectCommand.CommandText = thirty
            adapter.Fill(ds, "qevmake")

            'Table 31
            adapter.SelectCommand.CommandText = threeone
            adapter.Fill(ds, "actuator")

            'Table 32
            adapter.SelectCommand.CommandText = threetwo
            adapter.Fill(ds, "pr1_pr3")

            'Table 33
            adapter.SelectCommand.CommandText = threethree
            adapter.Fill(ds, "fr")

            'Table 34
            adapter.SelectCommand.CommandText = threefour
            adapter.Fill(ds, "fl")

            'Table 35
            adapter.SelectCommand.CommandText = threefive
            adapter.Fill(ds, "threewayvalve")

            'Table 36
            adapter.SelectCommand.CommandText = threesix
            adapter.Fill(ds, "pipeschedule1")

            'Table 37
            adapter.SelectCommand.CommandText = threeseven
            adapter.Fill(ds, "pipeschedule2")

            'Table 38
            adapter.SelectCommand.CommandText = threeeight
            adapter.Fill(ds, "kvforcage")

            'Table 39
            adapter.SelectCommand.CommandText = threenine
            adapter.Fill(ds, "prtable")

            'Table 40
            adapter.SelectCommand.CommandText = forty
            adapter.Fill(ds, "ratingclass")

            'Table 41
            adapter.SelectCommand.CommandText = fourone
            adapter.Fill(ds, "outputrecords")

            'Table 42
            adapter.SelectCommand.CommandText = fourtwo
            adapter.Fill(ds, "storagerecords")


            'Configuring the ComboBoxes
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "Sr_Nos"
            ComboBox1.DisplayMember = "Name"
            ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox2.DataSource = ds.Tables(1)
            ComboBox2.ValueMember = "Sr_Nos"
            ComboBox2.DisplayMember = "Name"
            ComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox3.DataSource = ds.Tables(2)
            ComboBox3.ValueMember = "Sr_Nos"
            ComboBox3.DisplayMember = "Name"
            ComboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox3.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox4.DataSource = ds.Tables(3)
            ComboBox4.ValueMember = "Sr_Nos"
            ComboBox4.DisplayMember = "Name"
            ComboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox4.AutoCompleteSource = AutoCompleteSource.ListItems


            ComboBox5.DataSource = ds.Tables(4)
            ComboBox5.ValueMember = "Sr_Nos"
            ComboBox5.DisplayMember = "Name"
            ComboBox5.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox5.AutoCompleteSource = AutoCompleteSource.ListItems


            ComboBox6.DataSource = ds.Tables(5)
            ComboBox6.ValueMember = "Sr_Nos"
            ComboBox6.DisplayMember = "Name"
            ComboBox6.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox6.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox7.DataSource = ds.Tables(6)
            ComboBox7.ValueMember = "Sr_Nos"
            ComboBox7.DisplayMember = "Name"
            ComboBox7.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox7.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox8.DataSource = ds.Tables(7)
            ComboBox8.ValueMember = "Sr_Nos"
            ComboBox8.DisplayMember = "Name"
            ComboBox8.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox8.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox9.DataSource = ds.Tables(8)
            ComboBox9.ValueMember = "Sr_Nos"
            ComboBox9.DisplayMember = "Name"
            ComboBox9.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox9.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox10.DataSource = ds.Tables(9)
            ComboBox10.ValueMember = "Sr_Nos"
            ComboBox10.DisplayMember = "Name"
            ComboBox10.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox10.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox11.DataSource = ds.Tables(10)
            ComboBox11.ValueMember = "Sr_Nos"
            ComboBox11.DisplayMember = "Name"
            ComboBox11.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox11.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox12.DataSource = ds.Tables(11)
            ComboBox12.ValueMember = "Sr_Nos"
            ComboBox12.DisplayMember = "Name"
            ComboBox12.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox12.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox13.DataSource = ds.Tables(12)
            ComboBox13.ValueMember = "Sr_Nos"
            ComboBox13.DisplayMember = "Name"
            ComboBox13.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox13.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox14.DataSource = ds.Tables(13)
            ComboBox14.ValueMember = "Sr_Nos"
            ComboBox14.DisplayMember = "Name"
            ComboBox14.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox14.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox15.DataSource = ds.Tables(14)
            ComboBox15.ValueMember = "Sr_Nos"
            ComboBox15.DisplayMember = "Name"
            ComboBox15.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox15.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox16.DataSource = ds.Tables(15)
            ComboBox16.ValueMember = "Sr_Nos"
            ComboBox16.DisplayMember = "Name"
            ComboBox16.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox16.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox17.DataSource = ds.Tables(16)
            ComboBox17.ValueMember = "Sr_Nos"
            ComboBox17.DisplayMember = "Name"
            ComboBox17.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox17.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox18.DataSource = ds.Tables(17)
            ComboBox18.ValueMember = "Sr_Nos"
            ComboBox18.DisplayMember = "Name"
            ComboBox18.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox18.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox19.DataSource = ds.Tables(18)
            ComboBox19.ValueMember = "Sr_Nos"
            ComboBox19.DisplayMember = "Name"
            ComboBox19.AutoCompleteSource = AutoCompleteSource.ListItems
            ComboBox19.AutoCompleteMode = AutoCompleteMode.SuggestAppend

            ComboBox20.DataSource = ds.Tables(19)
            ComboBox20.ValueMember = "Sr_Nos"
            ComboBox20.DisplayMember = "Name"
            ComboBox20.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox20.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox21.DataSource = ds.Tables(20)
            ComboBox21.ValueMember = "Sr_Nos"
            ComboBox21.DisplayMember = "Name"
            ComboBox21.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox21.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox22.DataSource = ds.Tables(21)
            ComboBox22.ValueMember = "Sr_Nos"
            ComboBox22.DisplayMember = "Name"
            ComboBox22.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox22.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox23.DataSource = ds.Tables(22)
            ComboBox23.ValueMember = "Sr_Nos"
            ComboBox23.DisplayMember = "Name"
            ComboBox23.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox23.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox24.DataSource = ds.Tables(23)
            ComboBox24.ValueMember = "Sr_Nos"
            ComboBox24.DisplayMember = "Name"
            ComboBox24.AutoCompleteSource = AutoCompleteSource.ListItems
            ComboBox24.AutoCompleteMode = AutoCompleteMode.SuggestAppend

            ComboBox25.DataSource = ds.Tables(24)
            ComboBox25.ValueMember = "Sr_Nos"
            ComboBox25.DisplayMember = "Name"
            ComboBox25.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox26.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox26.DataSource = ds.Tables(25)
            ComboBox26.ValueMember = "Sr_Nos"
            ComboBox26.DisplayMember = "Name"
            ComboBox26.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox26.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox27.DataSource = ds.Tables(26)
            ComboBox27.ValueMember = "Sr_Nos"
            ComboBox27.DisplayMember = "Name"
            ComboBox27.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox27.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox28.DataSource = ds.Tables(27)
            ComboBox28.ValueMember = "Sr_Nos"
            ComboBox28.DisplayMember = "Name"
            ComboBox28.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox28.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox29.DataSource = ds.Tables(28)
            ComboBox29.ValueMember = "Sr_Nos"
            ComboBox29.DisplayMember = "Name"
            ComboBox29.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ComboBox29.AutoCompleteSource = AutoCompleteSource.ListItems

            ComboBox30.DataSource = ds.Tables(29)
            ComboBox30.ValueMember = "Sr_Nos"
            ComboBox30.DisplayMember = "Name"
            ComboBox30.AutoCompleteMode = AutoCompleteMode.SuggestAppend

            ComboBox31.DataSource = ds.Tables(30)
            ComboBox31.ValueMember = "Sr_Nos"
            ComboBox31.DisplayMember = "actuator_name_model"

            ComboBox32.DataSource = ds.Tables(31)
            ComboBox32.ValueMember = "Sr_Nos"
            ComboBox32.DisplayMember = "valvesize_inches"

            ComboBox33.DataSource = ds.Tables(32)
            ComboBox33.ValueMember = "Sr_Nos"
            ComboBox33.DisplayMember = "renoyld_no"

            ComboBox34.DataSource = ds.Tables(33)
            ComboBox34.ValueMember = "Sr_Nos"
            ComboBox34.DisplayMember = "fl"

            ComboBox35.DataSource = ds.Tables(34)
            ComboBox35.ValueMember = "Sr_Nos"
            ComboBox35.DisplayMember = "valve_size_inches"

            ComboBox36.DataSource = ds.Tables(35)
            ComboBox36.ValueMember = "Sr_Nos"
            ComboBox36.DisplayMember = "pipe_size_inches"

            ComboBox37.DataSource = ds.Tables(36)
            ComboBox37.ValueMember = "Sr_Nos"
            ComboBox37.DisplayMember = "valve_size_in_mm"

            ComboBox38.DataSource = ds.Tables(37)
            ComboBox38.ValueMember = "Sr_Nos"
            ComboBox38.DisplayMember = "valve_size_inches"

            ComboBox39.DataSource = ds.Tables(38)
            ComboBox39.ValueMember = "Sr_Nos"
            ComboBox39.DisplayMember = "valvesize"

            ComboBox40.DataSource = ds.Tables(39)
            ComboBox40.ValueMember = "Sr_Nos"
            ComboBox40.DisplayMember = "temperature"

            'DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.DataSource = ds.Tables(0)


            'Sugggestions through TextBox 

            adapter.Dispose()
            command.Dispose()
            con.Dispose()

        Catch ex As Exception
            MsgBox("Cannot Connect to SQL Database")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim message As String = "Bonnet: " & ComboBox1.SelectedValue
        message += Environment.NewLine
        message += "End Connection: " & ComboBox2.SelectedValue
        message += Environment.NewLine
        message += "Body Mat: " & ComboBox3.SelectedValue
        message += Environment.NewLine
        message += "Plug: " & ComboBox4.SelectedValue
        message += Environment.NewLine
        message += "Seat: " & ComboBox5.SelectedValue
        message += Environment.NewLine
        message += "Top Mat: " & ComboBox6.SelectedValue
        message += Environment.NewLine
        message += "Gasket Mat: " & ComboBox7.SelectedValue
        message += Environment.NewLine
        message += "Painting: " & ComboBox8.SelectedValue
        message += Environment.NewLine
        message += "Positioner: " & ComboBox9.SelectedValue
        message += Environment.NewLine
        message += "SOV: " & ComboBox10.SelectedValue
        message += Environment.NewLine
        message += "AFR: " & ComboBox11.SelectedValue
        message += Environment.NewLine
        message += "ALR: " & ComboBox12.SelectedValue
        message += Environment.NewLine
        message += "Limit Switch Box: " & ComboBox13.SelectedValue
        message += Environment.NewLine
        message += "Vol Booster: " & ComboBox14.SelectedValue
        message += Environment.NewLine
        message += "Pos Trans: " & ComboBox15.SelectedValue
        message += Environment.NewLine
        message += "V Tank: " & ComboBox16.SelectedValue
        message += Environment.NewLine
        message += "Robotor: " & ComboBox17.SelectedValue
        message += Environment.NewLine
        message += "ITop: " & ComboBox18.SelectedValue
        message += Environment.NewLine
        message += "QEV: " & ComboBox19.SelectedValue
        message += Environment.NewLine
        message += "Certification: " & ComboBox20.SelectedValue
        message += Environment.NewLine
        message += "HandWheel: " & ComboBox21.SelectedValue
        message += Environment.NewLine
        message += "Tubing: " & ComboBox22.SelectedValue
        message += Environment.NewLine
        message += "Guiding: " & ComboBox23.SelectedValue
        message += Environment.NewLine
        message += "Positioner Make: " & ComboBox24.SelectedValue
        message += Environment.NewLine
        message += "AFR Make: " & ComboBox25.SelectedValue
        message += Environment.NewLine
        message += "ALR Make: " & ComboBox26.SelectedValue
        message += Environment.NewLine
        message += "Sov Make: " & ComboBox27.SelectedValue
        message += Environment.NewLine
        message += "Vol Booster Make: " & ComboBox28.SelectedValue
        message += Environment.NewLine
        message += "Limit Switch Make: " & ComboBox29.SelectedValue
        message += Environment.NewLine
        message += "QEV Make: " & ComboBox30.SelectedValue
        message += Environment.NewLine
        message += "Actuator: " & ComboBox31.SelectedValue
        message += Environment.NewLine
        message += "PR1_PR3: " & ComboBox32.SelectedValue
        message += Environment.NewLine
        message += "FR: " & ComboBox33.SelectedValue
        message += Environment.NewLine
        message += "FL: " & ComboBox34.SelectedValue
        message += Environment.NewLine
        message += "3 Way Valve: " & ComboBox35.SelectedValue
        message += Environment.NewLine
        message += "Pipe Schedul 1: " & ComboBox36.SelectedValue
        message += Environment.NewLine
        message += "Pipe Schedul 2: " & ComboBox37.SelectedValue
        message += Environment.NewLine
        message += "KV for CAGE: " & ComboBox38.SelectedValue
        message += Environment.NewLine
        message += "PR Table: " & ComboBox39.SelectedValue
        message += Environment.NewLine
        message += "Rating Class: " & ComboBox40.SelectedValue
        MessageBox.Show(message)

    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox1.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox2.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox3.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox3.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox4.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox4.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox5.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox5.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox6_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox6.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox6.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox7.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox7.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox8_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox8.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox8.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox9_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox9.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox9.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox10_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox10.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox10.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox11_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox11.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox11.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox12_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox12.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox12.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox13_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox13.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox13.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox14_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox14.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox14.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox15_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox15.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox15.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox16_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox16.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox16.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox17_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox17.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox17.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox18_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox18.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox18.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox19_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox19.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox19.DroppedDown = False
        End If
    End Sub

    Private Sub ComboBox20_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox20.KeyDown
        If e.KeyCode = 8 Then
            Exit Sub
        Else
            ComboBox20.DroppedDown = False
        End If
    End Sub

End Class
