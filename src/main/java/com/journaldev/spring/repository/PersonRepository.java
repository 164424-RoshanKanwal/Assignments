package com.journaldev.spring.repository;

import org.springframework.data.repository.CrudRepository;

import com.journaldev.spring.model.Person;

import java.util.List;

public interface PersonRepository<P> extends CrudRepository<Person, Long> {//has declaration of all CRUD functionbs
    List<Person> findByFirstName(String firstName);
}
