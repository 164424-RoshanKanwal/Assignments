package com.roshan.springbootcricbuzz.controller;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStream;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.mongodb.core.query.Criteria;
import org.springframework.data.mongodb.core.query.Query;
import org.springframework.data.mongodb.gridfs.GridFsOperations;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.mongodb.BasicDBObject;
import com.mongodb.DBObject;
import com.mongodb.gridfs.GridFSDBFile;

@RestController
public class BinaryDataController {

	@Autowired
	private GridFsOperations gridFsOperations;
	
	String fieldId="";
	
	 @RequestMapping("/")
	    public String home(){
	        return "Hello World!";
	    }
	 
	 @RequestMapping("/saveImage")
	public String saveFile() throws FileNotFoundException {

		DBObject metadata = new BasicDBObject();
		metadata.put("organization", "Roshan Kanwal");
		InputStream inputStream = new FileInputStream("src/main/resources/one.png");  //C:\Users\rkanwal\Desktop\1.jpeg
		metadata.put("type","image");
		fieldId= gridFsOperations.store(inputStream,"one.png", "image/png", metadata).getId().toString();
		System.out.println("FieldId = " + fieldId);
		
		return "Successfully added";
	}

	 @RequestMapping("/retrieve/image")
	public String retrieveFile() throws IOException {
		GridFSDBFile dbFile =  gridFsOperations.findOne(new Query(Criteria.where("_id").is(fieldId)));
		dbFile.writeTo("C:/Users/rkanwal/Desktop/");
		System.out.println("FieldId = " + dbFile.getFilename());
		return "File Retrieved";
	}
}
