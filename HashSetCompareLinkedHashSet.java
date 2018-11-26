/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package roshanpractice;

import java.util.HashSet;
import java.util.LinkedHashSet;

/**
 *
 * @author admin
 */
public class HashSetCompareLinkedHashSet {
    
    public static void main(String[] args) {
        
        HashSet hashSet = new HashSet();
        hashSet.add("Roshan");
        hashSet.add("kanwal");
        hashSet.add("R");
        hashSet.add("K");//insertion order is not maintained
        hashSet.add("O");
        hashSet.add("A");
        
        System.out.println(hashSet);
        
        LinkedHashSet linkHashSet = new LinkedHashSet();
        linkHashSet.add("Roshan");
        linkHashSet.add("kanwal");
        linkHashSet.add("R");
        linkHashSet.add("K");
        linkHashSet.add("O");//insertion order is maintained
        linkHashSet.add("A");
        
        System.out.println(linkHashSet);
    }
}
