function SomeFunction(numbers){

    var num = prompt("Enter the condition of operation; 1 for odd numbers \n 2 for prime ");
    num=parseInt(num);
    
    if(num==1){
        //code for even numbers
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
    // looping through 2 to number-1
    for (let i = 2; i < number; i++) {
       
        if (number % i == 0) {
            isPrime = false;
            break;
        }
    }

    if (isPrime) {
        console.log(`${number} is a prime number`);
        return true;
    } else {
        // console.log(`${number} is a not prime number`);
        return false;
    }
    
    
    
}
