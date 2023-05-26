Public Class frmCustomerDetails

    Private Sub frmCustomerDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try

            CustomerName = txtCustomer.Text
            ProjectName = txtProject.Text
            OfferNo = txtOffferNo.Text
            Revision = txtRevNo.Text
            TagNo = txtTagNo.Text
            QTY = txtQty.Text
            SheetNo = txtSheetNo.Text
            ItemNo = txtItemNo.Text
            SalesEnggName = txtSalesEngg.Text
            CustomerRef = txtCustomerRef.Text

            frmValveSizing.txtCustomerMain.Text = CustomerName
            '  lblProject.Text = ProjectName
            frmValveSizing.txtProjectMain.Text = ProjectName
            '    lblTagNo.Text = TagNo
            frmValveSizing.txtTagNoMain.Text = TagNo
            '    lblQTY.Text = QTY
            frmValveSizing.txtQTYMain.Text = QTY
            frmValveSizing.txtOfferNoMain.Text = OfferNo
            frmValveSizing.txtRevisionNoMain.Text = Revision
            frmValveSizing.txtSheetNo.Text = SheetNo
            frmValveSizing.txtItemNoMain.Text = ItemNo
            frmValveSizing.txtEnggNameMain.Text = SalesEnggName
            frmValveSizing.txtCustomerRefMain.Text = CustomerRef

            'frmValveSizing.lblCustomer.Text = txtCustomer.Text
            'frmValveSizing.lblProject.Text = txtProject.Text

            'frmValveSizing.lblTagNo.Text = txtTagNo.Text
            'frmValveSizing.lblQTY.Text = txtQty.Text
            'frmValveSizing.lblSalesEngg.Text = txtSalesEngg.Text

        Catch ex As Exception
            MsgBox("frmCustomerDetails_FormClosing:  " & "  " & ex.Message)
        End Try

    End Sub

    Private Sub frmCustomerDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            txtCustomer.Text = CustomerName
            txtProject.Text = ProjectName
            txtOffferNo.Text = OfferNo
            txtRevNo.Text = Revision
            txtTagNo.Text = TagNo
            txtQty.Text = QTY
            txtSheetNo.Text = SheetNo
            txtItemNo.Text = ItemNo
            txtSalesEngg.Text = SalesEnggName
            txtCustomerRef.Text = CustomerRef
        Catch ex As Exception
            MsgBox("frmCustomerDetails_Load:  " & "  " & ex.Message)
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

   
   
    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress, txtSheetNo.KeyPress, txtRevNo.KeyPress
        Try
            If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Or (e.KeyChar = "." And CType(sender, TextBox).Text.ToCharArray().Count(Function(c) c = ".") > 0) Then
                e.Handled = True

            End If
        Catch ex As Exception
            MsgBox("txtFlashingPercentageCase1_KeyPress:  " & ex.Message)
        End Try
    End Sub
End Class