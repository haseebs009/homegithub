const prams=new URLSearchParams(location.search);

for(const [key,value] of prams)
{
   
    if(key=="name")
    {
        document.getElementById('name').innerText=''+value+'\n';
    }
    if(key=="email")
    {
        document.getElementById('email').innerText=' '+value+'\n';
    }
    if(key=="dob")
    {
        document.getElementById('dob').innerText=' '+value+'\n';
    }
    if(key=="interests")
    {
        document.getElementById('interests').innerText=''+value+'\n';
    }
    if(key=="checkbox" &&value=="true")
    {
        document.getElementById('checkbox3').innerText='Organization'+'\n';
    }
    if(key=="checkbox1" &&value=="true" )
    {
        document.getElementById('checkbox3').innerText='Individual'+'\n';
    }
    if (key=="txtbox")
    {
        document.getElementById("txt").innerHTML+= value +'\n';
    }
}