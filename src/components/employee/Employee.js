import React, {Component} from "react";
import './Employee.css';

export default class Employee extends Component{
 render()
 {
     return (
         <div>
            <span class="Header1" id="record">
        No Record Found!
        <span color="blue"></span>
    </span>
             <table>
               <tr>
               <th>FIRSTNAME</th>
            <th>LASTNAME</th>
            <th>EMAIL</th>
            <th>EDIT</th>
            <th>DELETE</th>
               </tr>
               <tr>
                   <td></td>
                   <td></td>
                   <td></td>
                   <td></td>
               </tr>
             </table>
         </div>
     )
 }

}
