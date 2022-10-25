var fieldStatus=false;
// displaying the user details on successful submission
function displayDetails(){
    console.log(obj);
    document.getElementById('details').innerHTML="<h3>Details: </h3>"+ "Name:"+obj.name + "pass" + obj.password;
}



var obj={
    'name':"blank",
    'number':"number",
    'password':"can't show",
}

function fieldsValidate(){
    document.getElementById('err').innerText="Errors in the form. Fix it.";
    //alert('soemthing');
    console.log(fieldStatus);
    return fieldStatus;


}

function NameValidate(){
    var name=document.getElementById('name').value;
    var namePattern=/^[a-zA-Z]+$/;
    var nameStatus;

//    console.log(name.value.match(namePattern));
    //name is valid
    if(namePattern.test(name)){

        document.getElementById('nameError').style.color="green";
        document.getElementById("nameError").innerText='Nice name bro!';
        nameStatus=true;
        fieldStatus=true;

        //setting the obj parameter to display later
        obj.name=name;
    }
    else{
        document.getElementById('nameError').style.color="red";

        document.getElementById("nameError").innerText='Not a valid name bro!';
        nameStatus=false;
        fieldStatus=false;

    }

    return nameStatus;

}

function NumberValidate(){
    var number=document.getElementById('number').value;
    var namePattern=/^[0-9]{10,10}$/;
    var nameStatus;

    console.log(namePattern.test(number));
    //name is valid
    if(namePattern.test(number)){

        document.getElementById('number').style.color="green";
        document.getElementById("number").innerText='valid name';
        nameStatus=true;
        fieldStatus=true;
        obj.number=number;

        //setting the obj parameter to display later

    }
    else{
        document.getElementById('number').style.color="red";

        document.getElementById("number").innerText='Not a valid name';
        nameStatus=false;
        fieldStatus=false;
    }

    return nameStatus;
}

function PasswordValidate(){
    const pass=document.getElementById("pass").value;
    const repass=document.getElementById('repass').value;
    var passStatus;

    if(pass.localeCompare(repass)){
        document.getElementById('repass').style.color="green";
        document.getElementById("repass").innerText='Password Matches';
        passStatus=true;
        fieldStatus=true;
        obj.password="";
    }

    else{
        document.getElementById('repass').style.color="red";
        document.getElementById("repass").innerText='Password do not match';
        passStatus=false;
        fieldStatus=false;
    }

    return passStatus;
}
