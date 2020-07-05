function valuecheck() {
    var UserName = document.getElementById("txtUserName").value;
    var Password = document.getElementById("txtPassword").value;
    if (UserName.trim() == "") {
        document.getElementById("lblResult").innerHTML = "Please enter use name";

        return false;
    }
    if (Password.trim() == "") {
        document.getElementById("lblResult").innerHTML = "Please enter password";

        return false;
    }
}