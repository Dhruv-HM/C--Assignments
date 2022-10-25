function validateEname(){
    var ele=document.getElementById("ename").value;
    var enamePattern=/^[a-z]{5,10}$/;

    var enameStatus;
    if(enamePattern.test(ele)){
        enameStatus=true;
        document.getElementsId('als').style.visiblity="visible";
        document.getElementsId('als').style.color="green";
    }
    else{
        enameStatus=false;
        document.getElementsId('als').style.visiblity="visible";
    }

    return enameStatus;
}