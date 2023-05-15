function saveForm()
{
    let uname = document.getElementById("uname").value;
    if(uname.length<6 || uname.length>8)
    {
        alert("Enter Username within 6-8 characters!!!");
    }
    let pin = document.getElementById("pin").value;
    if(pin != "^[a-z0-9]+$")
    {
        alert("The Pin must be alphanumeric!!!");
    }
    let opt = document.getElementById("options").value;
    if(opt == "Select State")
    {
        alert("You must select a state!!!");
    }

    if(document.getElementById("check").checked)
    {
        if(pin.length == 0)
        {
            document.getElementById("pinvalidate").innerText = "Pin is Required";
        }
    }
}