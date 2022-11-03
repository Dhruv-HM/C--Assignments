const express= require('express');
const cors=require('cors');
const bodyParser=require('body-parser');

//connect to mongodb database using mongoose
const mongoose=require('mongoose');
const { retryWhen } = require('rxjs-compat/operator/retryWhen');
mongoose.connect('mongodb://localhost:27017/phonebookDB').then(rres=>{
    console.log("mongodb connection established");
});

//create the database model for database operations and queries
let Contact = mongoose.model("contacts",{
    id:{type:Number},
    firstname:{type:String},
    lastname:{type:String},
    email: {type:String},
    gender: {type:String},
    phone: {type:String},
    dob: {type:String},
    city: {type:String},
    state: {type:String},
    country: {type:String},
    picture:{type:String}
 }
)

const app=express(); //create the express web app
app.use(cors({
    origin:"*", //or give "*"
    methods:"*"
}));
app.use(bodyParser.json()) //---application/json

//configure for request and response for different api methods:GET,POST,PUT and DELETE
app.get("/",function(req,res){
    //get all contacts from dtabase using model
    Contact.find((err,contacts)=>{
        if(err){
            res.send(err);
        }
        else{
            res.json(contacts);
        }
    });


    // res.send("Welcome to phonebook api");
});

app.get("/api/contacts",function(req,res){
    res.send("You have sent get all request");
});
app.get("/api/contacts/:id",function(req,res){
    let id= req.params.id;
    Contact.findOne({"id":id},function(err,data){
    if(err){
        res.send(err);
    }else{
        res.json(data);
    }
    });
})
//delete by contact
app.delete("/:id",function(req,res){
    let id = req.params.id;
    Contact.remove({"id":id},function(err,data){
        if(err){
            res.send(err);
        }else{
            // console.log("Record deleted")
            res.json(data);
        }
    })
})
//insert by id
app.post("/",function(req,res){
    //create new model instance
    let contact = new Contact();
    //specify field values of model from request body
    contact.id=req.body.id;
    contact.firstname=req.body.firstname;
    contact.lastname=req.body.lastname;
    contact.email=req.body.email;
    contact.gender=req.body.gender;
    contact.phone=req.body.phone;
    contact.dob=req.body.dob;
    contact.city=req.body.city;
    contact.state=req.body.state;
    contact.country=req.body.country;
    contact.picture=req.body.picture;
    //save model to db
    contact.save(function(err){
        if(err){
            res.send(err);
        }
        
        Contact.find(function(err,data){
            if(err){
                res.send(err);
            }else{
                res.json(data);
            }
            });
    });
});


//start the app at http://localhost:3000
const port=3000;
app.listen(port,()=>console.log(`Phonebook server started on port ${port}`));