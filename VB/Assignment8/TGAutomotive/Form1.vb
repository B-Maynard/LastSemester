'Bailey Maynard
'12/14/18
'***NOTE*** : If using the same input as the book, the tax will come out different as it seems
'             they use a 6% tax in the book instead of 8%. I used 8%.
'Purpose: lets user check boxes and input labor/parts for a car shop. Will then calculate what they owe, and display the costs accordingly.
Public Class Form1

    Dim partsCost As Decimal
    Dim labor As Integer

    Function ValidateInputs() As Boolean
        'Checks both text boxes to make sure they are valid numbers
        If Not Decimal.TryParse(txtParts.Text, partsCost) Then
            MessageBox.Show("Parts must be a valid decimal.")
            Return False
        End If
        If Not Integer.TryParse(txtLabor.Text, labor) Then
            MessageBox.Show("Labor must be a valid integer.")
            Return False
        End If

        Return True
    End Function

    Function CalcOilLubeCharges() As Decimal
        Dim totalCost As Decimal = 0.00

        'If the user checks the boxes in this group, it will add their price accordingly
        If chkOilChange.Checked Then
            totalCost += 36.0
        End If
        If chkLubeJob.Checked Then
            totalCost += 28.0
        End If

        Return totalCost
    End Function

    Function CalcFlushCharges() As Decimal
        Dim totalCost As Decimal = 0.00

        'Same as above. Checked boxes will be added to the total
        If chkRadiator.Checked Then
            totalCost += 50.0
        End If
        If chkTransmission.Checked Then
            totalCost += 120.0
        End If

        Return totalCost
    End Function

    Function CalcMiscCharges() As Decimal
        Dim totalCost As Decimal = 0.00

        'Same as above. Checked boxes will be added to the total
        If chkInspection.Checked Then
            totalCost += 15.0
        End If
        If chkMuffler.Checked Then
            totalCost += 200.0
        End If
        If chkTireRotation.Checked Then
            totalCost += 20.0
        End If

        Return totalCost
    End Function

    Sub CalculateTotalCharges()
        Dim totalCharges As Decimal = 0.00
        Dim servicesAndLabor As Decimal = 0.00
        Dim partsTax As Decimal = 0.00

        'Checks that inputs are valid. If not, will display error messages accordingly as coded above
        If ValidateInputs() Then
            'Calculates parts tax based on 8% tax, not 6% like in the book
            partsTax = partsCost * 0.08
            'Adds all charges together within services and labor category
            servicesAndLabor = CalcOilLubeCharges() + CalcFlushCharges() + CalcMiscCharges() + labor
            'Calculates all total charges
            totalCharges = servicesAndLabor + partsCost + partsTax

            'Outputs charges accordingly
            lblServicesOutput.Text = servicesAndLabor.ToString("c")
            lblPartsOutput.Text = partsCost.ToString("c")
            lblTaxOutput.Text = partsTax.ToString("c")
            lblFeesOutput.Text = totalCharges.ToString("c")
        End If

    End Sub

    Sub ClearOilLube()
        'Clears check boxes in oil/lube category
        chkOilChange.Checked = False
        chkLubeJob.Checked = False
    End Sub

    Sub ClearFlushes()
        'Clears check boxes in flush category
        chkRadiator.Checked = False
        chkTransmission.Checked = False
    End Sub

    Sub ClearMisc()
        'Clears all other misc check boxes
        chkInspection.Checked = False
        chkMuffler.Checked = False
        chkTireRotation.Checked = False
    End Sub

    Sub ClearOther()
        'Clears all text boxes and labels
        txtLabor.Clear()
        txtParts.Clear()
        lblFeesOutput.Text = ""
        lblPartsOutput.Text = ""
        lblServicesOutput.Text = ""
        lblTaxOutput.Text = ""
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Will calculate all charges and output accordingly
        CalculateTotalCharges()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears all items on the application
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the application
        Me.Close()
    End Sub
End Class
