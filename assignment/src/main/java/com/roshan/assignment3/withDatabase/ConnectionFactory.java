package com.roshan.assignment3.withDatabase;

import java.sql.*;

import com.roshan.assignment3.withDatabase.ConnectionFactory;

public class ConnectionFactory {
	private static Connection connection = null;

	public static Connection getConnection(){
		try {
			Class.forName("oracle.jdbc.driver.OracleDriver");
			connection = DriverManager.getConnection(
					"jdbc:oracle:thin:@localhost:1521:XE", "system", "orcl11g");

		} catch (SQLException | ClassNotFoundException e) {
			e.printStackTrace();
		}
		return connection;
	}

	public static void closeConnection() {
		try {
			connection.close();
		} catch (SQLException e) {
		e.printStackTrace();
		}
	}


}