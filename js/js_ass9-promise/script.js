function GetVideo(){
    const vidPromise = new Promise((resolve,reject)=>{
        setTimeout(function(){
            resolve("Got Video")
        },3000);
    });

    vidPromise.then((value)=>{
        console.log(value);
    }).then(AddIntro).then(AddSummary);
    
    return vidPromise;

}

function AddIntro(){
    const introPromise = new Promise((resolve,reject)=>{
        setTimeout(function(){
            resolve("Intro Added")
        },3000);
    });
    introPromise.then((value)=>{
        console.log(value);
    });
    return introPromise;

}

function AddSummary(){
    const summaryPromise = new Promise((resolve,reject)=>{
        setTimeout(function(){
            resolve("Summary Added")
        },3000);
    });
    summaryPromise.then((value)=>{
        console.log(value);
    });
    return summaryPromise;

}
