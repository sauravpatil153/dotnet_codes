namespace BLL;
public class HRManager{
    public static List<Department> GetAllDepartments(){
        List<Department> allDepartments = DAL.Connected.DBManager.GetAllDepartments();
        return allDepartments;
    }

    public static Department GetDepartmentDetails(int id){
        Department dept = DAL.Connected.DBManager.GetDepartmentDetails(id);
        return dept;
    }
}