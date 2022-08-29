<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cars.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Search</title>
     <script src="jquery.min.js" ></script>
    <script>    function SearchCarRequest() {

        let inputname = document.getElementById("searchcar").value;
        if (inputname == "") return;
      
            $.ajax({
                url: 'WebForm1.aspx/SearchCar',
                type: 'post',
                data: JSON.stringify({ "inputname": inputname }),
                dataType: 'JSON',
                contentType: 'application/json',
                async: false,
                success: function (data) {
                    if (data.d != '[]') {
                        data1 = JSON.parse(data.d);
                        data1.forEach(car => {
                            $("#carlist").append(`<li class="list-group-item">${car}</li>`);
                        });
                    }
                         }
            });
            return false;
        }

    </script>   
    
</head>

<body>
   
                <div>
                    <h1>Car Search</h1>
                 </div>
             <div>
                    <input type="text" id="searchcar" oninput="return SearchCarRequest()" class="input-group"/>
                </div>
             <div>
                     <ul id="carlist" class="list-group"></ul>
                </div>
 </body>
</html>
