var events=new Array();

function display(){

    var str="";
    for (let index = 0; index < events.length; index++) {
        str+="<li class='list-group-item'>"+events[index]+"</li>";        
    }

    document.getElementById('display').innerHTML=str;

}

function push(){
    ele=document.getElementById('event').value;
    events.push(ele);
}

function pop(){
    
    events.pop();
}