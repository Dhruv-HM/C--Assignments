var BuyTraining = /** @class */ (function () {
    function BuyTraining(trainings) {
        this.trainings = [];
        this.trainings = trainings;
        // this.trainings.push(new Training("Drupal","Drupal 8 for devs",8));
        // this.trainings.push(new Training("Angular","Angular 8 for devs",3));
        // this.trainings.push(new Training("NodeJs","NodeJs 8 for devs",2));
    }
    BuyTraining.prototype.buy = function (index) {
        console.log("You bought the course ".concat(index));
        this.trainings[index].display();
    };
    return BuyTraining;
}());
var Training = /** @class */ (function () {
    function Training(category, title, duration) {
        this.category = category;
        this.duration = duration;
        this.title = title;
    }
    Training.prototype.display = function () {
        console.log("Category: ".concat(this.category, " title: ").concat(this.title, " Duration: ").concat(this.duration));
    };
    return Training;
}());
var training1 = new Training("Drupal", "Drupal 8 for devs", 8);
var training2 = new Training("Angular", "Angular 8 for devs", 3);
var training3 = new Training("NodeJs", "NodeJs 8 for devs", 8);
var trainings = [];
trainings.push(training1);
trainings.push(training2);
trainings.push(training3);
var a = new BuyTraining(trainings);
//calling with the index to buy the course
a.buy(2);
// trainings.push(new Training)
// trainings.push(new Training("Drupal","Drupal 8 for devs",8));
// trainings.push(new Training("Angular","Angular 8 for devs",3));
// trainings.push(new Training("NodeJs","NodeJs 8 for devs",2));
