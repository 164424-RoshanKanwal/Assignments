/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package roshanpractice;

/**
 *
 * @author admin
 */
public class Employee {
    int empid;

    public Employee(int empid) {
        this.empid = empid;
    }

    public int getEmpid() {
        return empid;
    }

    public void setEmpid(int empid) {
        this.empid = empid;
    }
    
    
    
    
   @Override
    public boolean equals(Object obj){
    return true;
    }
    
    @Override
    public int hashCode(){
    return 3333553;
    }
    
    /*public static void main(String[] args) {
        Employee e = new Employee();
        
        
        
    }*/
}
