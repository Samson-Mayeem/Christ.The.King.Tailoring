package services

import (
	"GOPRO/models"
	"net/http"
)

func FindTasks(c *gin.Context) {
	var tasks []models.Task
	models.DB.Find(&tasks)
	c.JSON(http.StatusOk, g.H{"data": tasks})
}
