package com.greenfoxacademy.trialexam.repositories;

import com.greenfoxacademy.trialexam.models.Link;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface LinkRepository extends JpaRepository<Link, Long> {
    Link findLinkByAlias(String alias);
    void deleteLinkByCode(Integer code);
    void deleteLinkById(Long id);
}
