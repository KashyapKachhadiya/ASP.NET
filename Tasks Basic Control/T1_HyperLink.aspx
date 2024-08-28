<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T1_HyperLink.aspx.cs" Inherits="WebApplication1.Tasks_Basic_Control.T1_HyperLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Task 1 Charusat</title>
    <link href="~/Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/css/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="~/Content/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>CHAROTAR UNIVERSITY OF SCIENCE AND TECHNOLOGY</h1>
            <nav class="navbar navbar-expand-lg navbar-light bg-dark rounded">
                <asp:HyperLink ID="hlHome" runat="server" CssClass="navbar-brand text-white" NavigateUrl="#" Target="_self">Home</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="hlAbout" runat="server" CssClass="navbar-brand text-white" NavigateUrl="#About" Target="_self">About University</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="hlCourses" runat="server" CssClass="navbar-brand text-white" NavigateUrl="#Courses">Courses</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="hlDepartments" runat="server" CssClass="navbar-brand text-white" NavigateUrl="#Departments" Target="_self">Departments</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="hlStaff" runat="server" CssClass="navbar-brand text-white" NavigateUrl="#Staff" Target="_self">Staff Members</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="hlNews" runat="server" CssClass="navbar-brand text-white" NavigateUrl="#News" Target="_self">News</asp:HyperLink>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="hlContact" runat="server" CssClass="navbar-brand text-white" NavigateUrl="#Contact" Target="_self">Contact</asp:HyperLink>
            </nav>
            <h2>&nbsp;</h2>
            <h2>&nbsp;</h2>
            <h2 id="About">About University</h2>
            <p>Intelligence with Character is the true goal of Education. 
                Knowledge gives humility, from humility, one attains Character. 
                The Highest Education is that which makes our life in harmony with all existence. 
                In the context, CHARUSAT as a University has been quite distinct from day one. 
                It strives to make Charotar – the Land of Sardar Patel the Global Education Hub through knowledge creation, augmentation, and dissemination. 
                For the purpose, CHARUSAT dedicates its efforts towards developing synergy between industry and academia; 
                and community upliftment through education. Importantly, CHARUSAT continually strives to focus on the future with an entrepreneurial spirit.
                As a University, CHARUSAT is emerging with a thrust on socially relevant Research & Development. 
                For the purpose, a Research and Development Centre has been established on the Campus. 
                Uniquely, Space Research and Technology Centre is also established to initiate and foster research in Space Technology.Efforts are also 
                made for education amelioration in rural schools through a Rural Education Development Program.On-Campus and Outreach Activities are 
                organized for School – Students, Teachers, and Management. 
                Human Resource Development Centre hones competencies of Faculty and Staff on Campus.
                Through these initiatives and practices, CHARUSAT focuses on converting eyes into sight and vision; 
                information into knowledge and wisdom; and students / 
                individuals into citizens and harmonious living. Further, 
                programs at CHARUSAT enable the students not only to gain an understanding but also to 
                develop insights in altered research areas. Teachers also dedicate their efforts to 
                construct and facilitate opportunities where the students can practice and experience creativity. 
                Moving a step ahead towards the purpose of education, CHARUSAT aims to make its students 
                Job Creators and not Job Seekers.In order to inculcate values in the students, 
                CHARUSAT has been established as a University fostering High Moral Values. Honesty, 
                Integrity, and Transparency have been the benchmarks of CHARUSAT in both – word and action.
                In the journey, CHARUSAT fosters a niche for a world-class education at the rural base. 
                It aspires to be a World Class University. Primarily, it strives to be among 
                Top 20 Universities at National Level.I, earnestly, request you all to join hands with 
                CHARUSAT and work towards the realization of this aspiration. Many have already 
                volunteered in this Seva Yagna through their magnanimity, knowledge, skills and resource 
                sharing; and through their association with CHARUSAT either as a Faculty, Staff or Student.
                On behalf of CHARUSAT Family, I extend a word of gratitude to all and also 
                invite all to visit the Campus, witness the development and be a part of the Journey.
                - Mr. Surendra M. Patel</p>
            
            <h2 id="Courses">Courses</h2>
            <p>Computer Science and Engineering</p>
            <p>Computer Engineering</p>
            <p>Information Technology</p>
            <p>Artificial Intelligence and Machine Learning</p>

            <h2 id="Departments">Departments</h2>
            <p>Computer Science and Engineering</p>
            <p>Computer Engineering</p>
            <p>Information Technology</p>
            <p>Artificial Intelligence and Machine Learning</p>
            

            <h2 id="Staff">Staff Members</h2>
            <p>Prof. Faculty 1</p>
            <p>Prof. Faculty 2</p>
            <p>Prof. Faculty 3</p>
            <p>Prof. Faculty 4</p>

            <h2 id="News">News</h2>
            <p>Cognizace 2024</p>
            <p>Spoural 2024</p>
            <p>Utkarsh 2024</p>
            <p>Tedex 2024</p>

            <h2 id="Contact">Contact</h2>
            <p>Charotar University Of Science and Technology</p>
            <p>Devang Patel Institute of Advance Technology and Research</p>

        </div>
    </form>
</body>
</html>
