function valuecheck() {
    var firstname = document.getElementById("txtFirstName").value;
    var lastName = document.getElementById("txtLastName").value;
    if (firstname == "") {
        document.getElementById("lblResult").innerHTML = "Please enter first name";

        return false;
    }
    if (lastName == "") {
        document.getElementById("lblResult").innerHTML = "Please enter last name";

        return false;
    }
    document.getElementById("lblResult").innerHTML = "My name is : " + document.getElementById("txtFirstName").value + " " + document.getElementById("txtLastName").value;
}