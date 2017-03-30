var Employee = (function () {
    function Employee(_name, _rating) {
        this.Name = _name;
        this.Rating = _rating;
    }
    Employee.prototype.PerformanceReview = function () {
        document.write("Performance Review of " + this.Name + " is " + this.Rating + " out of 5.");
    };
    return Employee;
}());
var Team = (function () {
    function Team(_name, _supervisor) {
        this.Supervisor = _supervisor;
        this.Name = _name;
        this.Employees = [];
    }
    Team.prototype.add = function (employee) {
        this.Employees.push(employee);
    };
    Team.prototype.PerformanceReview = function () {
        document.write("<br>Team: " + this.Name + "<br>");
        document.write("Supervisor: " + this.Supervisor.Name + "<br>");
        document.write("Members Reviews <br>");
        for (var _i = 0, _a = this.Employees; _i < _a.length; _i++) {
            var employee = _a[_i];
            employee.PerformanceReview();
        }
    };
    return Team;
}());
document.write("Build Employees <br>");
var jason = new Employee('Jason Lee Scott', 3);
var trini = new Employee('Trini Kwan', 4);
var zach = new Employee('Zach Taylor', 5);
var kimberly = new Employee('Kimberly Ann Hart', 3);
var billy = new Employee('Billy Cranston', 4);
var rose = new Employee('Tommy Oliver', 5);
var alpha = new Employee('Alpha', 5);
var zordon = new Employee('Zordon', 5);
document.write("Build Team1 <br>");
var team1 = new Team("team1", alpha);
team1.add(jason);
team1.add(trini);
team1.add(zach);
team1.add(kimberly);
team1.add(billy);
team1.add(rose);
document.write("Build PowerTeam <br><br>");
var powerTeam = new Team("PowerTeam", zordon);
powerTeam.add(alpha);
powerTeam.add(team1);
document.write("Start Performance Summaries <br>");
powerTeam.PerformanceReview();
//# sourceMappingURL=example.js.map