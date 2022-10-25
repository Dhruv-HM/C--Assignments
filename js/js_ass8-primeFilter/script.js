function filterFunction(numbers){

    var num = prompt("Enter 1 for odd numbers \n 2 for prime ");
    num=parseInt(num);

    if(num==1){
      
        var oddNumbers= numbers.filter((n)=>{return n%2!=0;});
        return oddNumbers;
    }

    if(num==2){
        var primeNums=numbers.filter(primeNumber);
        return primeNums;
    }

}
function primeNumber(number){

    var isPrime=true;
    for (let i = 2; i < number; i++) {

        if (number % i == 0) {
            isPrime = false;
            break;
        }
    }

    if (isPrime) {
        return true;
    } else {

        return false;
    }

}
