// the usual thing
function oddNum(array){
    var res=[];
    for(num of array){
        if(num%2!=0){
            res.push(num);
        }
    }
    return res;
}


//with the filter function
function oddNum(numbers){
    var oddNumbers= numbers.filter((n)=>{return n%2!=0;});
    return oddNumbers;
}

