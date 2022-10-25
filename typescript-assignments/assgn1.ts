class BuyTraining{
    trainings:Training[]=[];
    
    constructor(trainings:Training[]){
        this.trainings=trainings;
        // this.trainings.push(new Training("Drupal","Drupal 8 for devs",8));
        // this.trainings.push(new Training("Angular","Angular 8 for devs",3));
        // this.trainings.push(new Training("NodeJs","NodeJs 8 for devs",2));
    }

    buy(index:number){
        console.log(`You bought the course ${index}`);
        this.trainings[index].display();
    }
}


class Training{
    category:string;
    title:string;
    duration:number;

    constructor(category:string,title:string,duration:number){
        this.category=category;
        this.duration=duration;
        this.title=title;
    }

    display():void{
        console.log(`Category: ${this.category} title: ${this.title} Duration: ${this.duration}`);
    }
}


var training1=new Training("Drupal","Drupal 8 for devs",8);
var training2=new Training("Angular","Angular 8 for devs",3);
var training3=new Training("NodeJs","NodeJs 8 for devs",8);

let trainings:Training[]=[];
trainings.push(training1);
trainings.push(training2);
trainings.push(training3);

var a=new BuyTraining(trainings);


//calling with the index to buy the course
a.buy(2);


// trainings.push(new Training)
// trainings.push(new Training("Drupal{","Drupal 8 for devs"},8));
// trainings.push(new Training("Angular","Angular 8 for devs",3));
// trainings.push(new Training("Node{Js","NodeJs 8 for devs",2))};