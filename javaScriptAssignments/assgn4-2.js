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
    const vidPromise = new Promise((resolve,reject)=>{
        setTimeout(function(){
            resolve("Intro Added")
        },3000);
    });
    vidPromise.then((value)=>{
        console.log(value);
    });
    return vidPromise;

}

function AddSummary(){
    const vidPromise = new Promise((resolve,reject)=>{
        setTimeout(function(){
            resolve("Summary Added")
        },3000);
    });
    vidPromise.then((value)=>{
        console.log(value);
    });
    return vidPromise;

}

GetVideo();