SELECT persona.cuil, persona.id, persona.razon
FROM persona
WHERE (((persona.cuil) In (SELECT [cuil] FROM [persona] As Tmp GROUP BY [cuil] HAVING Count(*)>1 )))
ORDER BY persona.cuil;
