Option Strict On
''' <summary>
''' Author Name:    Harmanjot Kaur
''' Project Name:   Car_Inventory
''' Date:           15 March, 2019
''' Description     Application to keep a list of cars and some information about the cars.
''' </summary>

Public Class Car

    Private Shared carCount As Integer                          'static or shared private variable to hold the number of cars
    Private carIdentificationNumber As Integer = 0              'private variable to hold the identification number of cars
    Private carMake As String = String.Empty                    'private variable to hold the make of the car
    Private carModel As String = String.Empty                   'private variable to hold the model of the car
    Private carYear As String = String.Empty                    'private variable to hold the year of the car
    Private carPrice As String = String.Empty                   'private variable to hold the price of the car
    Private carNewStatus As Boolean = False                     'private variable to hold the car's status

    ''' <summary>
    ''' Constructor - Default - creates a new car object
    ''' </summary>
    Public Sub New()
        carCount += 1                                   ' increment the shared/static variable counter by 1
        carIdentificationNumber = carCount              ' assign the car id
    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new car object
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="newStatus"></param>
    Public Sub New(make As String, model As String, year As String, price As String, newStatus As Boolean)

        ' call the other constructor 
        ' to set the car count and
        ' to set the car id
        Me.New()

        carMake = make                   ' set the car make
        carModel = model                 ' set the car model
        carYear = year                   ' set the car year 
        carPrice = price                 ' set the car price
        carNewStatus = newStatus         ' set the car status

    End Sub

    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of cars that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific car identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' NewCarStatus Property - >Gets and Sets the new Car Status
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property NewCarStatus() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(ByVal value As Boolean)
            carNewStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Make property - Gets and Sets the make of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Model property - Gets and Sets the model of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Year property - Gets and Sets the year of a car
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Price property - Gets and Sets the price of a car
    ''' </summary>
    ''' <returns>Double</returns>
    Public Property Price() As String
        Get
            Return carPrice
        End Get
        Set(value As String)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "The car details are as follows: " & vbCrLf & "Make: " & carMake & vbCrLf & "Model: " & carModel & vbCrLf & "Year: " & carYear & vbCrLf & "Car Price: " & vbCrLf & "New Status: " & IIf(carNewStatus = True, "It's a new Car", "It's not a new Car").ToString()

    End Function

End Class