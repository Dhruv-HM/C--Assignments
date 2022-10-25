function add(...numbers){

    let res=0;
    if(numbers.length==0){
      return 0;
    }
    else{
      for(let i=0;i<numbers.length;i++){
          res+=numbers[i]
      }
    }
    return res;
}

let res=add(1,2,1,2,3,4,5); // any number of parameters can be passed to add function
console.log("sum: ",res)
