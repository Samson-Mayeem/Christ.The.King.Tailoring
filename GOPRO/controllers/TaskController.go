package controllers

import (
	"GOPRO/models"
	"net/http"
)

type CreateTaskInput struct {
	TaskName   string `json:"task_name" binding:"required"`
	TaskDetail string `json:"task_detail" binding:"required"`
}

type UpdateTaskInput struct {
	TaskName   string `json:"task_name" binding:"required"`
	TaskDetail string `json:"task_detail" binding:"required"`
}

func CreateTask(c *gin.Context) {
	// Validate input
	var input CreateTaskInput
	if err := c.ShouldBindJSON(&input); err != nil {
		c.JSON(http.StatusBadRequest, gin.H{"error": err.Error()})
		return
	}

	// Create task
	task := models.Task{TaskName: input.TaskName, TaskDetail: input.TaskDetail, Date: "2020-03-10 00:00:00"}
	models.DB.Create(&task)

	c.JSON(http.StatusOK, gin.H{"data": task})

}
