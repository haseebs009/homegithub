function getElements()
{
let name=document.getElementById("fname").value;
let email=document.getElementById("email").value;
let dob=document.getElementById("dob").value;
let interests=document.getElementById("interest").value;
let checkbox1=document.getElementById("individual").checked;
let checkbox=document.getElementById("organization").checked;
let txtbox=document.getElementById("txtbx").value;

try { 
if( name.length==0)  throw "Name can not be empty";
if( email.length==0)  throw "email can not be empty" ;
if( dob.length==0)  throw "Date of birth can not be empty" ;
if( interests.length==0)  throw "Interest selection can not be empty" ;
if(checkbox==false && checkbox1==false) throw "checkbox selection can not be empty" ;
if( txtbox.length<=1)  throw "text box can not be empty" ;
}
catch(err) {  
alert (err);
re
}

const params= new URLSearchParams(
{
name,
email, 
dob,
interests,
checkbox1,
checkbox,
txtbox,
})
window.open("summary.html?"+params.toString());
}

