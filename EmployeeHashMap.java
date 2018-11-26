/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package roshanpractice;

import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

/**
 *
 * @author admin
 */
public class EmployeeHashMap {
    
    
    public static void main(String[] args) {
        
        HashMap<Employee, String> hashMap = new HashMap();
        
        Employee e = new Employee(101);
        Employee e1 = new Employee(102);
        Employee e2= new Employee(103);
        Employee e3 = new Employee(104);
        
        System.out.println(hashMap.put(e, "Roshan"));//put method return type is null if a new element is added
        System.out.println(hashMap.put(e1, "Roshani"));//here the new element is compared to with older one
        System.out.println(hashMap.put(e3, "Roshans"));//if they are equal the value is replaced and the return type is the value
        System.out.println(hashMap.put(e2, "Roshanis"));//which is replaced for ex all the value are replaced 
        //
        
        System.out.println(e.equals(e2));
        System.out.println(hashMap.get(e));
        System.out.println(hashMap.get(e1).hashCode());//only one memory is available which is allocated to every key-value pair
        System.out.println(hashMap.get(e2).hashCode());//therefore only the last key-value pair sustain at that location
        System.out.println(hashMap.get(e3).hashCode());
        
       /* Iterator itr = hashMap.iterator();
        while(true){
            Map.Entry me = (Map.Entry)itr.next();
            me.getKey();
            me.getValue();
            
        }
        */
    }
}
