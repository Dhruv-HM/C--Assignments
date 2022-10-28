function add(...numbers){

    if(numbers.length==0){
        return "Pass something";
    }
    
    let res=0;
    for(let i=0;i<numbers.length;i++){
        res+=numbers[i]
    }
    
    return res;
}

let res=add(); // any number of parameters can be now passed to add function
console.log("sum: ",res);