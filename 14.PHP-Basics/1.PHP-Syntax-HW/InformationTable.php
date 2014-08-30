<!DOCTYPE html>
<html>
<head>
    <title>Information Table</title>
    <style>
        table {
            border-collapse: collapse;
        }
        table th {
            background-color: orange;
            font-weight: bold;
            text-align: left;
            border: 1px solid black;
            padding: 5px;
        }
        table td {
            text-align: right;
            border: 1px solid black;
            padding: 5px;
        }

    </style>
</head>
<body>
<?php
$name = 'Gosho';
$phone = '0882-321-423';
$age = 24;
$address = 'Hadji Dimitar';
?>
<table>
    <tr>
        <th>Name</th>
        <td><?=$name?></td>
    </tr>
    <tr>
        <th>Phone Number</th>
        <td><?=$phone?></td>
    </tr>
    <tr>
        <th>Age</th>
        <td><?=$age?></td>
    </tr>
    <tr>
        <th>Address</th>
        <td><?=$address?></td>
    </tr>
</table>
</body>
</html>


