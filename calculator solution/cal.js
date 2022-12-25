
function dis(val)
{
document.getElementById("edu").value += val;
}


//store value, function for evaluation, result display
function solve()
{
let a = document.getElementById("edu").value;
 let sum = eval(a) ;
 document.getElementById("edu").value =  sum;
 
}



//function for clearing the display
function clr()
{
document.getElementById("edu").value = ""
}


