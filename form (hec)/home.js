/*-----------------------------------------------------------------------------------------------------------------------------------*/
/*personal*/
///collecting data from text boxes////


function submit(){

  var form =document.querySelector('form'); 

  
  form.addEventListener('submit', (e) => {
  e.preventDefault(); // Prevent HTML refresh
  onchange="loadFile(events)"// Handle form with JavaScript here

}

  )
  
var fname= document.getElementById('fname');
var lname= document.getElementById('lname');
  if (mname != "")
  {
    var fullname= fname + " " + mname + " " + lname;
  }
  else {
    var fullname= fname + " " + lname;
  }
fullname =  document.getElementById("fullname").innerHTML;

birthday =  document.getElementById("birthday").innerHTML=   document.getElementById("birthday").value;;
martial=    document.getElementById("martial").innerHTML=    document.querySelectorAll('input[name="martial"]:checked').values;
gender=     document.getElementById("gender").innerHTML=     document.getElementById("gender").innerHTML= document.querySelectorAll('input[name="gender"]:checked').values;
province=   document.getElementById("province").innerHTML=   document.querySelectorAll('#province').values;
country=    document.getElementById("country").innerHTML=    document.querySelectorAll('#country').values;
city=       document.getElementById("city").innerHTML=       document.querySelectorAll('#city').values;
religion=   document.getElementById("religion").innerHTML=   document.querySelectorAll('#religion').values;
occupation= document.getElementById("occupation").innerHTML= document.querySelectorAll('#occupation').values;
fthname=    document.getElementById("fthname").innerHTML=    document.getElementById('fthname');



}
   
/// Age  calculation///

function age()
{
  var userinput = document.getElementById("birthday").value;  
  var birthday = new Date(userinput);  
  var month_diff = Date.now() - birthday.getTime(); 
  var age_dt = new Date(month_diff);
  var year = age_dt.getUTCFullYear(); 
  var age = Math.abs(year - 1990);
  return document.getElementById("showbithday").innerHTML =    
   age + " years. "; 

}


