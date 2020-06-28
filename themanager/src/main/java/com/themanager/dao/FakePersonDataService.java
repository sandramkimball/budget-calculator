package com.example.themanager.dao;
import com.example.themanager.models.Person;
import java.util.UUID;
import org.springframework.stereotype.Repository;

// tell Spring to instantiated this class as beans to inject to other classes
// 'fakeDao' to be replaced by whatever db usd (ex. mongo)
@Repository('fakeDao')

public class FakePersonDataService implements PersonDao {
    private static List<Person> DV = new ArrayList<>();

    @Override
    public int insertPerson(UUID id, Person person){
        DB.add( new Person(id, person.getName() ));
        return 1
    }
}