const express = require('express')
const app = express();
const port = 3200;

app.get('/',(req,res)=>{
    res.send('Hello Arvind,How are you');
}) 

app.listen(port,()=>{
    console.log("Listening........", port)
})