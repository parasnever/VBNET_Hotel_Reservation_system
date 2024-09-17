Public Class ManageReservationsForm
    Dim room As New ROOMS()
    Private Sub ManageReservationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the datagridview with all the reservation



        'populate the combobox type with all room's type
        ComboBoxType.DataSource = room.getAllRoomsType()
        ComboBoxType.DisplayMember = "label"
        ComboBoxType.ValueMember = "id"



        'populate the combobox room number with all room numbers
        ComboBoxRoomNumber.DataSource = room.getAllRooms()
        ComboBoxRoomNumber.DisplayMember = "number"
        ComboBoxRoomNumber.ValueMember = "number"



    End Sub
End Class