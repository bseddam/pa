<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #primary_nav_wrap
{
	margin-top:15px
}

#primary_nav_wrap ul
{
	list-style:none;
	position:relative;
	float:left;
	margin:0;
	padding:0;

}

#primary_nav_wrap ul a
{
	display:block;
	color:#333;
	text-decoration:none;
	font-weight:700;
	font-size:12px;
	line-height:32px;
	padding:0 15px;
	font-family:"HelveticaNeue","Helvetica Neue",Helvetica,Arial,sans-serif
}

#primary_nav_wrap ul li
{
	position:relative;
	float:left;
	margin:0;
	padding:0;
}

/*#primary_nav_wrap ul li.current-menu-item
{
	background:#ddd
}*/

#primary_nav_wrap ul li:hover
{
	background:#f6f6f6
}

#primary_nav_wrap ul ul
{
	display:none;
	position:absolute;
	top:100%;
	left:0;
	background:#fff;
	padding:0
}

#primary_nav_wrap ul ul li
{
	float:none;
	width:200px
}

#primary_nav_wrap ul ul a
{
	line-height:120%;
	padding:10px 15px
}

#primary_nav_wrap ul ul ul
{
	top:0;
	left:100%
}

#primary_nav_wrap ul li:hover > ul
{
	display:block
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Simple Pure CSS Drop Down Menu</h1>
<nav id="primary_nav_wrap">
<ul>
<%--  <li class="current-menu-item"><a href="#">Home</a></li>--%>
  <li><a href="#">Menu 1</a>
    <ul>
      <li><a href="#">Sub Menu 1</a></li>
      <li><a href="#">Sub Menu 2</a></li>
      <li><a href="#">Sub Menu 3</a></li>
      <li><a href="#">Sub Menu 4</a>
        <ul>
          <li><a href="#">Deep Menu 1</a>
            <ul>
              <li><a href="#">Sub Deep 1</a></li>
              <li><a href="#">Sub Deep 2</a></li>
              <li><a href="#">Sub Deep 3</a></li>
                <li><a href="#">Sub Deep 4</a></li>
            </ul>
          </li>
          <li><a href="#">Deep Menu 2</a></li>
        </ul>
      </li>
      <li><a href="#">Sub Menu 5</a></li>
    </ul>
  </li>
 </ul>
</nav>
    </div>
    </form>
</body>
</html>
