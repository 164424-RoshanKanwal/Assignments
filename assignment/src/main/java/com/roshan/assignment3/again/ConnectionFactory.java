package com.roshan.assignment3.again;

import java.sql.*;



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

//	public static void main(String[] args) throws ShoppingCartException {
//		System.out.println(ConnectionFactory.getConnection());
//	}
}