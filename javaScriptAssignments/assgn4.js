 function getVideo(){
    return new Promise((resolve,reject)=>{
        setTimeout(()=>{
            resolve("Get Added");
        },3000);        
    });
 }

 function introAdded(){
    return new Promise((resolve,reject)=>{
        setTimeout(()=>{
            resolve("Intro Added");
        },3000);        
    });
 }

 function summaryAdded(){
    return new Promise((resolve,reject)=>{
        setTimeout(()=>{
            resolve("Summary Added");
        },3000);        
    });
 }


// getVideo().then((res)=>{
//     console.log(res);
//     introAdded().then((res)=>{
//         console.log(res);
//         summaryAdded().then((res)=>{
//             console.log(res);
//         })
//     })
// });




function doTask(){
    return new Promise(function(resolve,reject){
        resolve("task");
    });
}


doTask().then((res)=>{
    console.log(res);
}).then(introAdded).then(summaryAdded);

// promise.then(()=>{
//    setTimeout(() => {
//      "invalid";
//     console.log("t1");
//    }, 3000); 
// }).catch().then(()=>{
//     setTimeout(()=>{
//         console.log("t2");
//     },3000);   
// }).then(()=>{
//     setTimeout(()=>{
//         console.log("t3");
//     },3000);
// })



// function GetVideo(){
//     setTimeout(()=>{
//         console.log("Getting the video");
//     },3000);
// }

// function IntroAdded(){
//     setTimeout(()=>{
//         console.log("getting the intro");
//     },3000);
// }


// function SummaryAdded(){
//     setTimeout(()=>{
//         console.log("summary is added");
//     },3000);
// }





